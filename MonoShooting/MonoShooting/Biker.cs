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
        private bool _movingForward = false;

        //test
        private int _motionIndex = 0;
        private bool _isMoving = false;
        private int _frameMax = 4;
        private int _frameCount = 0;
        private const int FRAME_WIDTH = 48;

        public bool Dead { get; set; }

        public Biker(ContentManager content)
        {
            Content = content;
            Radius = 18; // 48 / 2 - alpha
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
            if (!Dead)
            {
                // idle motion
                _timer -= gameTime.ElapsedGameTime.TotalSeconds;
                if (_timer < 0)
                {
                    _motionIndex += FRAME_WIDTH;
                    _frameCount++;
                    if (_frameCount >= _frameMax)
                    {
                        _frameCount = 0;
                        _motionIndex = 0;
                    }
                    _timer = 1;
                }

                // jump motion
                if (_jumped)
                {
                    _timer -= gameTime.ElapsedGameTime.TotalSeconds;
                    Position.Y += 60 * elapsedTime;

                    if (_timer <= 0.85)
                    {
                        _motionIndex += FRAME_WIDTH;
                        _frameCount++;
                        if (_frameCount >= _frameMax)
                        {
                            _frameCount = 0;
                            _motionIndex = 0;
                        }
                        _timer = 1;
                        _jumped = false;
                        Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
                    }
                }

                if (_movingForward && !_jumped)
                {
                    _timer -= gameTime.ElapsedGameTime.TotalSeconds;

                    if (_timer <= 0.85)
                    {
                        _motionIndex += FRAME_WIDTH;
                        _frameCount++;
                        if (_frameCount >= _frameMax)
                        {
                            _frameCount = 0;
                            _motionIndex = 0;
                        }
                        _timer = 1;
                    }
                }

                if (kState.IsKeyUp(Keys.Right) ||
                    kState.IsKeyUp(Keys.Up) ||
                    kState.IsKeyUp(Keys.Down))
                {
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
                    _movingForward = true;
                    _frameMax = 4;
                }

                if (kState.IsKeyDown(Keys.Right))
                {
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                    if (Position.X < 1400 - FRAME_WIDTH)
                    {
                        Position.X += 30 * elapsedTime;
                    }
                    _movingForward = true;
                    _frameMax = 6;
                }

                if (kState.IsKeyDown(Keys.Left))
                {
                    Position.X -= 30 * elapsedTime;
                }

                if (kState.IsKeyDown(Keys.Up))
                {
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                    if (Position.Y > 815)
                    {
                        Position.Y -= 30 * elapsedTime;
                    }
                    _movingForward = true;
                    _frameMax = 6;
                }
                if (kState.IsKeyDown(Keys.Down))
                {
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                    if (Position.Y < 915)
                    {
                        Position.Y += 30 * elapsedTime;
                    }
                    _movingForward = true;
                    _frameMax = 6;
                }
                if (kState.IsKeyDown(Keys.Space))
                {
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_jump");
                    if (Position.Y > 815)
                    {
                        Position.Y -= 60 * elapsedTime;
                    }
                    _jumped = true;
                }

            }
            else
            {
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_death");
                _timer -= gameTime.ElapsedGameTime.TotalSeconds;
                if (_timer < 0.7)
                {
                    _motionIndex += FRAME_WIDTH;
                    _frameCount++;
                    if (_frameCount >= _frameMax)
                    {
                        _frameCount = 0;
                        _motionIndex = 0;
                    }
                    _timer = 1;
                    GameController.GameOver = true;                    
                }                
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                Sprite, 
                new Vector2(Position.X, Position.Y - Radius), 
                new Rectangle(_motionIndex, 0, 48, 48), 
                Color.White);
        }
    }
}
