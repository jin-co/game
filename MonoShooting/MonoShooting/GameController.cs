using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class GameController
    {
        private double _timer = 2;
        public List<Bullet> bullets = new List<Bullet>();

        public static bool GameOver { get; set; }
        public static bool GameStart { get; set; }
        public static bool GameClear { get; set; }
        public static double TotalTime { get; set; }
        public static int GameLevel { get; set; }
        public static bool Climbable { get; internal set; }

        public GameController() {
            TotalTime = 0;
        }        

        public void Update(GameTime gameTime)
        {            
            _timer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (!GameOver)
            {
                TotalTime += gameTime.ElapsedGameTime.TotalSeconds;
                if (_timer <= 0)
                {
                    bullets.Add(new Bullet());
                    _timer = 2;
                }
            }
            else
            {
                MediaPlayer.Play(Sounds.BackgroundMusicInbound);
                bullets.Clear();
            }
        }

        public void ResetBullets()
        {
            bullets.Clear();
        }
    }
}
