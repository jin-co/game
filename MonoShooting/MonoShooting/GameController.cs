using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class GameController
    {
        public List<Bullet> bullets = new List<Bullet>();
        public bool GameOver { get; set; }
        private double _timer = 2;
        public GameController() {
            this.GameOver = false;
        }

        

        public void Update(GameTime gameTime)
        {
            _timer -= gameTime.ElapsedGameTime.TotalSeconds;
            
            if (!GameOver)
            {
                if (_timer <= 0)
                {
                    bullets.Add(new Bullet());
                    _timer = 2;
                }
            }
        }
    }
}
