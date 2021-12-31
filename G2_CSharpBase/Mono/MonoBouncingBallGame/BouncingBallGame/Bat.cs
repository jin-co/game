using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BouncingBallGame
{
    class Bat
    {
        private Texture2D sprite;
        private Vector2 speed = new Vector2(4, 0);
        private Vector2 position;
        public Vector2 ScreenDimension;

        public void Load (ContentManager Content)
        {
            sprite = Content.Load<Texture2D>("Images/Bat");
            position = new Vector2((800 - sprite.Width)/2, 480 - 20);
        }

        // prepare for collision detection
        public Rectangle GetBound ()
        {
            return new Rectangle((int)position.X, (int)position.Y, sprite.Width, sprite.Height);
        }

        // game loop
        public void Update (GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();

            if (keyState.IsKeyDown (Keys.Right))
            {
                position += speed;
            }

            if (keyState.IsKeyDown (Keys.Left))
            {
                position -= speed;
            }

            // check boundary
            if (position.X < 0) // left
            {
                position.X = 0;
            }

            if ((position.X + sprite.Width) > ScreenDimension.X) // right
            {
                position.X = ScreenDimension.X - sprite.Width;
            }
        }

        public void Draw (GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, Color.White);
        }
    }
}
