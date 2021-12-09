using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // biker class that controls the player
    class Biker
    {
        #region Field
        private Texture2D _sprite;
        private double _timer = 1;
        private bool _jumped = false;
        private bool _movingForward = false;
        private bool _movingLeft;
        private const int FRAME_WIDTH = 48;
        private int _frameX = 0;
        private int _frameMax = 4;
        private int _frameCount = 0;
        private int _speed = 30;
        public Vector2 Position = new Vector2(50, 815);
        #endregion

        #region Properties
        public int Radius { get; set; }        
        public bool OnSecondStage { get; set; }
        public bool Dead { get; set; }
        #endregion

        #region Controllers
        public Biker()
        {
            Radius = 18; 
        }
        #endregion

        public void BikerLoad()
        {
            _sprite = SpriteLoader.Load("Assets/Biker/Biker_idle");            
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
                    _frameX += FRAME_WIDTH;
                    _frameCount++;
                    if (_frameCount >= _frameMax)
                    {
                        _frameCount = 0;
                        _frameX = 0;
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
                        Sounds.Jump.Play();
                        _frameX += FRAME_WIDTH;
                        _frameCount++;
                        if (_frameCount >= _frameMax)
                        {
                            _frameCount = 0;
                            _frameX = 0;
                        }
                        _timer = 1;
                        _jumped = false;
                        _sprite = SpriteLoader.Load("Assets/Biker/Biker_idle");
                    }
                }

                if (_movingForward && !_jumped)
                {
                    _timer -= gameTime.ElapsedGameTime.TotalSeconds;                    
                    if (_timer <= 0.85)
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

                if (kState.IsKeyUp(Keys.Right) ||
                    kState.IsKeyUp(Keys.Up) ||
                    kState.IsKeyUp(Keys.Down))
                {
                    _sprite =  SpriteLoader.Load("Assets/Biker/Biker_idle");
                    _movingForward = true;
                    _frameMax = 4;
                }

                if (kState.IsKeyDown(Keys.Right))
                {                    
                    if (GameController.Climbable)
                    {
                        if (Position.X < 1324 - FRAME_WIDTH)
                        {
                            Position.X += (_speed / 3) * elapsedTime;
                        }
                    }
                    else
                    {
                        _sprite =  SpriteLoader.Load("Assets/Biker/Biker_run");
                        if (Position.X < 1400 - FRAME_WIDTH)
                        {
                            Position.X += _speed * elapsedTime;
                        }
                    }
                    
                    _movingForward = true;
                    _movingLeft = false;
                    if (_jumped || GameController.Climbable)
                    {
                        _frameMax = 4;
                    }
                    else
                    {
                        _frameMax = 6;
                    }
                }

                if (kState.IsKeyDown(Keys.Left))
                {
                    if (GameController.Climbable)
                    {
                        if (Position.X > 1300)
                        {
                            Position.X -= (_speed / 3) * elapsedTime;
                        }
                    }
                    else
                    {
                        _sprite =  SpriteLoader.Load("Assets/Biker/Biker_run_left");
                        if (Position.X > 0 + FRAME_WIDTH)
                        {
                            Position.X -= _speed * elapsedTime;
                        }
                    }                    
                    _movingForward = true;
                    _movingLeft = true;
                    if (_jumped || GameController.Climbable)
                    {
                        _frameMax = 4;
                    }
                    else
                    {
                        _frameMax = 6;
                    }                    
                }

                if (kState.IsKeyDown(Keys.Up) && !GameController.Climbable)
                {
                    _sprite =  SpriteLoader.Load("Assets/Biker/Biker_run");
                    if (_movingLeft)
                    {
                        _sprite = SpriteLoader.Load("Assets/Biker/Biker_run_left");
                    }
                    
                    if (OnSecondStage)
                    {
                        if (Position.Y > 640)
                        {
                            Position.Y -= _speed * elapsedTime;
                        }
                    }
                    else
                    {
                        if (Position.Y > 815)
                        {
                            Position.Y -= _speed * elapsedTime;
                        }
                    }
                    
                    _movingForward = true;
                    if (_jumped)
                    {
                        _frameMax = 4;
                    }
                    else
                    {
                        _frameMax = 6;
                    }
                }
                if (kState.IsKeyDown(Keys.Down))
                {
                    _sprite =  SpriteLoader.Load("Assets/Biker/Biker_run");
                    if (_movingLeft)
                    {
                        _sprite = SpriteLoader.Load("Assets/Biker/Biker_run_left");
                    }

                    if (OnSecondStage)
                    {
                        if (Position.Y < 703)
                        {
                            Position.Y += _speed * elapsedTime;
                        }
                    }
                    else
                    {
                        if (Position.Y < 915)
                        {
                            Position.Y += _speed * elapsedTime;
                        }
                    }

                    _movingForward = true;
                    if (_jumped)
                    {
                        _frameMax = 4;
                    }
                    else
                    {
                        _frameMax = 6;
                    }
                }

                // jump
                if (kState.IsKeyDown(Keys.Space) && !GameController.Climbable)
                {
                    _sprite =  SpriteLoader.Load("Assets/Biker/Biker_jump");
                    if (_movingLeft)
                    {
                        _sprite =  SpriteLoader.Load("Assets/Biker/Biker_jump_left");
                    }
                    if (OnSecondStage)
                    {
                        if (Position.Y < 703)
                        {
                            Position.Y -= 60 * elapsedTime;
                        }
                    }
                    else
                    {
                        if (Position.Y > 815)
                        {
                            Position.Y -= 60 * elapsedTime;
                        }
                    }

                    _jumped = true;
                }

                // climb
                if (GameController.Climbable && 
                    kState.IsKeyDown(Keys.Up) &&
                    kState.IsKeyDown(Keys.Space))
                {
                    _sprite =  SpriteLoader.Load("Assets/Biker/Biker_climb");                    if (Position.Y <= 700)
                    {                        
                        OnSecondStage = true;
                    }
                    Position.Y -= _speed * elapsedTime;
                    _frameMax = 6;                    
                }
            }
            else
            {                
                _sprite =  SpriteLoader.Load("Assets/Biker/Biker_death");
                _timer -= gameTime.ElapsedGameTime.TotalSeconds;                
                if (_timer < 0.7)
                {
                    
                    _frameX += FRAME_WIDTH;
                    _frameCount++;
                    if (_frameCount >= _frameMax)
                    {
                        _frameCount = 0;
                        _frameX = 0;
                    }
                    _timer = 1;
                    GameController.GameOver = true;                    
                }

                if (GameController.GameOver == true)
                {                    
                    if (kState.IsKeyDown(Keys.Enter))
                    {
                        GameController.GameOver = false;
                        GameController.GameStart = false;
                        GameController.TotalTime = 0;
                        GameController.GameLevel = 1;
                        OnSecondStage = false;
                        Dead = false;
                        Position = new Vector2(50, 815);
                        MediaPlayer.Play(Sounds.BackgroundMusicEnd);
                    }
                }
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                _sprite, 
                new Vector2(Position.X, Position.Y - Radius), 
                new Rectangle(_frameX, 0, 48, 48), 
                Color.White);
        }
    }
}
