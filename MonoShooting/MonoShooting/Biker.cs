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
        public int Radius { get; set; }
        public List<Rectangle> Rectangles { get; set; }
        public Vector2 Position = new Vector2(50, 815);  //bottom: 900 -> 912/ top: 795 -> 810
        private double _timer = 1;
        //test 

        private bool _jumped = false;

        //test
        private int _motionIndex = 1;
        private bool _isMoving = false;

        public Biker(ContentManager content)
        {
            Content = content;
            Radius = 18; // 48 / 2 - alpha
        }

        public Texture2D BikerLoad()
        {
            Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_attack1");
            Rectangles = new List<Rectangle> { };
            for (int i = 0; i < 30; i++)
            {
                Rectangles.Add(new Rectangle(i, 0, 48, 48));
            }
            return Sprite;
        }

        public void BikerUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            //_timer -= gameTime.ElapsedGameTime.TotalSeconds;
            _motionIndex++;            
            if (_motionIndex > 5)
            {
                _motionIndex = 0;
            }

            if (_jumped)
            {
                _timer -= gameTime.ElapsedGameTime.TotalSeconds;
                Position.Y += 20 * elapsedTime;
                
                if (_timer <= 0)
                {
                    _timer = 1;
                    _jumped = false;
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
                }
            }

            if (_isMoving)
            {
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
                if (_timer <= 0)
                {
                    _motionIndex++;
                    _timer = 1;
                    if (_motionIndex > 5)
                    {
                        _motionIndex = 0;
                    }
                }
            }            

            if (kState.IsKeyDown(Keys.Right))
            {
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                _motionIndex++;
                if (_timer <= 0)
                {
                    _motionIndex++;
                    _timer = 1;
                    if (_motionIndex > 5)
                    {
                        _motionIndex = 0;
                    }
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
                if (Position.Y > 815)
                {
                    Position.Y -= 30 * elapsedTime;
                }
            }
            if (kState.IsKeyDown(Keys.Down))
            {
                if (Position.Y < 915)
                {
                    Position.Y += 30 * elapsedTime;
                }
            }
            if (kState.IsKeyDown(Keys.Space))
            {
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_jump");
                
                Position.Y -= 160 * elapsedTime;                
                _jumped = true;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, new Vector2(Position.X, Position.Y - Radius), new Rectangle(48, 0, 48, 48), Color.White);
            spriteBatch.Draw(Sprite, new Vector2(Position.X, Position.Y + 30), Color.White);
        }
    }
}
