using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // dog class that controls the dog
    class Dog
    {
        #region Fields
        private static int _frameX = 0;
        private static int _frameMax = 4;
        private static int _frameCount = 0;
        private const int FRAME_WIDTH = 48;
        private int _speed;
        private double _timer = 1;
        public Vector2 position;
        #endregion

        #region Properties
        public static Texture2D Sprite { get; set; }
        public int Radius { get; set; }
        #endregion

        #region Contructors
        public Dog()
        {
            Random random = new Random();
            this._speed = random.Next(10, 50);
            this.position = new Vector2(random.Next(100, 950), random.Next(643, 703));
            Sprite = SpriteLoader.Load("Assets/Enemies/Dog/Walk");
            Radius = 3;
        }
        #endregion

        public void Update(GameTime gameTime, Vector2 playerPos)
        {
            Sprite = SpriteLoader.Load("Assets/Enemies/Dog/Walk");
            if (playerPos.X < position.X)
            {
                Sprite = SpriteLoader.Load("Assets/Enemies/Dog/Walk_left");
            }
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            // motion
            _timer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (_timer < 0.5)
            {                
                _frameX += FRAME_WIDTH;
                _frameCount++;
                if (_frameCount >= _frameMax)
                {
                    _frameCount = 0;
                    _frameX = 0;
                }
                _frameMax = 6;
                _timer = 1;
            }

            if (position.Y > 640 && position.Y < 703)
            {
                Vector2 moveDir = playerPos - position;
                moveDir.Normalize(); 
                position += moveDir * _speed * elapsedTime;
            }
        }

        public static void Draw(GameTime gameTime, 
            SpriteBatch spriteBatch, Vector2 dogPosition)
        {            
            spriteBatch.Draw(
                Sprite,
                new Vector2(dogPosition.X, dogPosition.Y),
                new Rectangle(_frameX, 0, 48, 48),
                Color.White);
        }
    }
}
