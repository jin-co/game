using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Biker
    {
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Rectangle> Rectangles { get; set; }
        public Vector2 Position = new Vector2(50, 795);  //bottom: 900 / top: 975

        //test 

        //test
        private int _motionIndex = 01;
        private bool _isMoving = false;

        public Biker(ContentManager content)
        {
            Content = content;            
        }

        public Texture2D BikerLoad()
        {
            Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
            Rectangles = new List<Rectangle> { };
            for (int i = 0; i < 6; i++)
            {
                Rectangles.Add(new Rectangle(0, i, 48, 48));
            }
            return Sprite;
        }

        public void BikerUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kState.IsKeyDown(Keys.Right))
            {
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                _motionIndex++;
                if (_motionIndex > 5)
                {
                    _motionIndex = 0;
                }
                _isMoving = true;
                Position.X += 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                Position.X -= 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                Position.Y -= 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                Position.Y += 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Space))
            {
                for (int i = 0, j = 200; i < 2; i++)
                {
                    if (i == 0)
                    {
                        Position.Y += j * elapsedTime;
                    }
                }
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, Position, Rectangles[_motionIndex], Color.White);
        }
    }
}
