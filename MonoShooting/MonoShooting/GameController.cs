using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // game controller class that controls the flow of the 
    // entire game
    class GameController
    {
        #region Fields
        private double _timer = 2;
        public List<Bullet> Bullets = new List<Bullet>();
        public List<Dog> Dogs = new List<Dog>();      
        #endregion

        #region Properties
        public static bool GameOver { get; set; }
        public static bool GameStart { get; set; }
        public static bool GameClear { get; set; }
        public static double TotalTime { get; set; }
        public static int GameLevel { get; set; }
        public static bool Climbable { get; set; }
        public static bool Pause { get; set; }
        #endregion

        #region Constructors
        public GameController() {
            TotalTime = 0;
            GameLevel = 1;
            Pause = false;
        }
        #endregion

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
                        Dogs.Clear();
                        Bullets.Add(new Bullet());                        
                    }
                    
                    if (GameController.GameLevel == 2)
                    {
                        Bullets.Clear();
                        if (Dogs.Count < 10)
                        {
                            Dogs.Add(new Dog());
                        }
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
    }
}
