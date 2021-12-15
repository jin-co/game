using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Pause
    {
        private static float _timer = 1;
        public static void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            _timer -= elapsedTime;

            if (_timer < 0.8)
            {
                if (kState.IsKeyDown(Keys.S))
                {
                    GameController.Pause = !GameController.Pause;
                }
                _timer = 1;
            }
            

        }
    }
}
