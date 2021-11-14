using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BouncingBallGame
{
    class Explosion
    {
        private Texture2D sprite;
        public Vector2 Position;
        private Vector2 dimension;
        private List<Rectangle> frames;
        private int frameIndex = -1;
        private int delay = 5;
        private int delayCounter = 0;
        public bool Enable;

        public Explosion (ContentManager Content)
        {
            sprite = Content.Load<Texture2D>("Images/explosion");
            dimension = new Vector2(64, 64);
            Position = Vector2.Zero;
            CreateFrames();
            Enable = false;
        }

        private void CreateFrames()
        {
            frames = new List<Rectangle>();
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col ++)
                {
                    int x = col * (int)dimension.X;
                    int y = row * (int)dimension.Y;
                    Rectangle grid = new Rectangle(x, y, (int)dimension.X, (int)dimension.Y);
                    frames.Add(grid);
                }
            }
        }

        // game loop
        public void Update (GameTime gameTime)
        {
            if (Enable)
            {
                delayCounter++;
                if (delayCounter > delay)
                {
                    frameIndex++;
                    if (frameIndex > 24)
                    {
                        frameIndex = -1;
                        Enable = false;
                    }
                    delayCounter = 0;
                }
            }
        }

        public void Draw (GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (Enable && (frameIndex >= 0))
                spriteBatch.Draw (sprite, Position, frames[frameIndex], Color.White);
        }
    }
}
