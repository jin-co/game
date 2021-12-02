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

        public GameController() {
            this.GameOver = false;
        }

        

        public void Update(GameTime gameTime)
        {
            if (!GameOver)
            {
                bullets.Add(new Bullet());
            }
        }
    }
}
