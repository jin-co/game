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
        public List<Bullet> Bullets = new List<Bullet>();
        public List<Dog> Dogs = new List<Dog>();

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
                // total time
                TotalTime += gameTime.ElapsedGameTime.TotalSeconds;
                if (_timer <= 0)
                {
                    if (GameController.GameLevel == 1)
                    {
                        Bullets.Add(new Bullet());                        
                    }
                    
                    if (GameController.GameLevel == 2)
                    {
                        Dogs.Add(new Dog());
                    }
                    _timer = 2;
                }
            }
            else
            {
                MediaPlayer.Play(Sounds.BackgroundMusicInbound);
                Bullets.Clear();
                Dogs.Clear();
            }
        }

        public void ResetBullets()
        {
            Bullets.Clear();
        }
    }
}
