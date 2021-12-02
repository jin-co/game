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
        public Vector2 Location = new Vector2(50, 50);

        //test
        private int _motionIndex = -1;

        public Biker(ContentManager content)
        {
            Content = content;            
        }

        public Texture2D BikerLoad()
        {
            Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
            return Sprite;
        }

        public void BikerUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Rectangles = new List<Rectangle> { };
            for (int i = 0; i < 4; i++)
            {
                Rectangles.Add(new Rectangle(0, i, 48, 48));
            }

            //idle
            //if (_motionIndex > 2)
            //{
            //    _motionIndex = -1;
            //}
            //_motionIndex++;

            if (kState.IsKeyDown(Keys.Right))
            {
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                Rectangles = new List<Rectangle> { };
                for (int i = 0; i < 6; i++)
                {
                    Rectangles.Add(new Rectangle(0, i, 48, 48));
                }
                if (_motionIndex > 5)
                {
                    _motionIndex = -1;
                }
                _motionIndex++;
                Location.X += 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Left))
            {
                Location.X -= 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Up))
            {
                Location.Y -= 30 * elapsedTime;
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                Location.Y += 30 * elapsedTime;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, Location, Rectangles[_motionIndex], Color.White);
        }
    }
}
