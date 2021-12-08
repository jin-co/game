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
    class Biker
    {
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Radius { get; set; }        
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

        public Biker(ContentManager content)
        {
            Content = content;
            Radius = 18; // 48 / 2 - alpha
        }

        public void BikerLoad()
        {
            Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
            Sounds.Jump = Content.Load<SoundEffect>("Assets/Sounds/sound_jump");
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
                        Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
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
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
                    _movingForward = true;
                    _frameMax = 4;
                }

                if (kState.IsKeyDown(Keys.Right))
                {                    
                    if (GameController.Climbable)
                    {
                        if (Position.X < 1324 - FRAME_WIDTH)
                        {
                            Position.X += 10 * elapsedTime;
                        }
                    }
                    else
                    {
                        Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                        if (Position.X < 1400 - FRAME_WIDTH)
                        {
                            Position.X += 30 * elapsedTime;
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
                            Position.X -= 10 * elapsedTime;
                        }
                    }
                    else
                    {
                        Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run_left");
                        if (Position.X > 0 + FRAME_WIDTH)
                        {
                            Position.X -= 30 * elapsedTime;
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
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                    if (_movingLeft)
                    {
                        Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run_left");
                    }
                    
                    if (OnSecondStage)
                    {
                        if (Position.Y > 640)
                        {
                            Position.Y -= 30 * elapsedTime;
                        }
                    }
                    else
                    {
                        if (Position.Y > 815)
                        {
                            Position.Y -= 30 * elapsedTime;
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
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run");
                    if (_movingLeft)
                    {
                        Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_run_left");
                    }

                    if (OnSecondStage)
                    {
                        if (Position.Y < 703)
                        {
                            Position.Y += 30 * elapsedTime;
                        }
                    }
                    else
                    {
                        if (Position.Y < 915)
                        {
                            Position.Y += 30 * elapsedTime;
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
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_jump");
                    if (Position.Y > 815)
                    {                        
                        Position.Y -= 60 * elapsedTime;
                    }
                    _jumped = true;
                }

                // climb
                if (kState.IsKeyDown(Keys.Up) &&
                    kState.IsKeyDown(Keys.Space))
                {
                    Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_climb");

                    if (Position.Y <= 700)
                    {                        
                        OnSecondStage = true;
                    }
                    Position.Y -= 30 * elapsedTime;
                    _climbing = true;
                    _frameMax = 6;                    
                }
            }
            else
            {                
                Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_death");
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
                Sprite, 
                new Vector2(Position.X, Position.Y - Radius), 
                new Rectangle(_frameX, 0, 48, 48), 
                Color.White);
        }
    }
}
