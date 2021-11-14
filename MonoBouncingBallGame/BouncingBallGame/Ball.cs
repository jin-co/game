using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BouncingBallGame
{
    class Ball
    {
        private Texture2D sprite;
        private Vector2 position;
        private SoundEffect hitSound;
        private SoundEffect missSound;
        private bool enable = false;
        public Vector2 ScreenDimension;
        public Vector2 speed = new Vector2(5, -5);
        public Explosion explosion;

        public void Load (ContentManager Content)
        {
            sprite = Content.Load<Texture2D>("Images/Ball");
            hitSound = Content.Load<SoundEffect>("Music/click");
            missSound = Content.Load<SoundEffect>("Music/applause1");
            position = new Vector2((ScreenDimension.X - sprite.Width) / 2, (ScreenDimension.Y - sprite.Height) - 200);
            enable = true;
        }

        // prepare for collision detection
        public Rectangle GetBound ()
        {
            return new Rectangle((int)position.X, (int)position.Y, sprite.Width, sprite.Height);
        }

        // game loop
        public void Update (GameTime gameTime)
        {
            if (enable)
            {
                position += speed;
                if (position.Y <= 0) // Top hit
                {
                    speed.Y = Math.Abs(speed.Y); // change the ball movement direction
                    hitSound.Play();
                }

                if ((position.X + sprite.Width) >= ScreenDimension.X) // Right hit 
                {
                    speed.X = -Math.Abs(speed.X);
                    hitSound.Play();
                }

                if (position.X <= 0) // Left hit
                {
                    speed.X = Math.Abs(speed.X);
                    hitSound.Play();
                }

                // game stops here - game over
                if (position.Y >= ScreenDimension.Y) // Bottom hit
                {
                    missSound.Play();
                    enable = false;
                    explosion.Enable = false;
                }
            }

            // restart the game
            if (Keyboard.GetState().IsKeyDown (Keys.Enter))
            {
                enable = true;
                position = new Vector2((ScreenDimension.X - sprite.Width) / 2, (ScreenDimension.Y - sprite.Height) - 100);
                speed = new Vector2(5, -5);
            }
        }

        public void Draw (GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, Color.White);
        }
    }
}
