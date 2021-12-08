using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Dog
    {
        public Vector2 position;
        public int speed;
        public int radius = 3;

        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Radius { get; set; }
        public List<Rectangle> Rectangles { get; set; }
        public bool OnSecondStage { get; set; }

        public Vector2 Position = new Vector2(1350, 815); //50, 815
        private double _timer = 1;
        //test 

        private bool _jumped = false;
        private bool _movingForward = false;
        private bool _movingLeft;
        private bool _climbing = false;

        //test
        private int _frameX = 0;
        private int _frameMax = 4;
        private int _frameCount = 0;
        private const int FRAME_WIDTH = 48;

        public bool Dead { get; set; }

        public Dog()
        {
            Random random = new Random();
            this.speed = 200;
            this.position = new Vector2(random.Next(100, 950), random.Next(643, 703));
        }

        public void Update(GameTime gameTime)
        {
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            // idle motion
            _timer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (_timer < 0)
            {
                _frameX += FRAME_WIDTH;
                _frameCount++;
                if (_frameCount >= _frameMax)
                {
                    _frameCount = 0;
                    _frameX = 0;
                }
                _timer = 1;
            }
        }
    }
}
