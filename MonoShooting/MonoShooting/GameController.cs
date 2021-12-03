using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class GameController
    {
        public List<Bullet> bullets = new List<Bullet>();
        public static bool GameOver { get; set; }
        public static bool StartGame { get; set; }

        private double _timer = 2;

        public bool Clear { get; set; }
        public GameController() {
            this.Clear = false;
        }        

        public void Update(GameTime gameTime)
        {
            KeyboardState kState = new KeyboardState();
            _timer -= gameTime.ElapsedGameTime.TotalSeconds;
            
            if (!GameOver)
            {
                if (_timer <= 0)
                {
                    bullets.Add(new Bullet());
                    _timer = 2;
                }
            }
            else
            {
                if (_timer <= 0.9)
                {
                    bullets.Add(new Bullet());
                    if (kState.IsKeyDown(Keys.Enter))
                    {
                        StartGame = false;
                        _timer = 2;
                    }
                }                
            }
        }

        public void ResetBullets()
        {
            bullets.Clear();
        }
    }
}
