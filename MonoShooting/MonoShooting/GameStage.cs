using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // gamestage class that controls the game level
    class GameStage
    {
        public void Update(GameTime gameTime, Biker biker)
        {
            KeyboardState kState = Keyboard.GetState();            
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (GameController.GameLevel)
            {
                case 1:
                    if (kState.IsKeyDown(Keys.Enter))
                    {
                        GameController.GameClear = false;
                        GameController.GameLevel = 2;
                        MediaPlayer.Play(Sounds.BackgroundMusicSlayer);
                    }

                    break;
                case 2:
                    if (kState.IsKeyDown(Keys.Enter))
                    {
                        GameController.GameStart = false;
                        GameController.GameClear = false;
                        GameController.GameLevel = 1;
                        biker.Position = new Vector2(50, 815);
                        biker.OnSecondStage = false;
                    }
                    break;
            }
        }
    }
}
