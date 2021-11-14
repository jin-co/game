using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoCarRace
{
    class CarSet
    {
        private Random random = new Random();
        private int NoOfCars = 3;
        private Texture2D[] carTextures;
        private string[] spriteName = { "redCar", "whiteCar", "yellowCar" };
        private SpriteFont stateFont;

        private int startX = 0;
        private int[] startY = { 
            GameMain.ScreenHeight - 65, 
            GameMain.ScreenHeight - 91, 
            GameMain.ScreenHeight - 117 
        };

        private Vector2[] positions = { Vector2.Zero, Vector2.Zero, Vector2.Zero };
        private bool[] winstates = { false, false, false };
        private bool[] reported = { false, false, false };

        private string[] carReports = { "Red Car:", "White Car: ", "Yellow Car: " };
        private int winnerCount = 0;
        private string stateOut;
        private string statesOut;

        public CarSet(ContentManager Content)
        {
            StartGame();
            carTextures = new Texture2D[NoOfCars];
            // load all the car images
            for (int n = 0; n < NoOfCars; n++)
            {
                carTextures[n] = Content.Load<Texture2D>(spriteName[n]);
            }
            stateFont = Content.Load<SpriteFont>("statefont");
        }

        public void StartGame()
        {
            for (int n = 0; n < NoOfCars; n++)
            {
                positions[n] = new Vector2(startX, startY[n]);
                winstates[n] = false;
                reported[n] = false;
            }
            statesOut = "";
            winnerCount = 0;
            GameElement.carSoundInstance.Play();
        }

        public void Update(GameTime gameTime)
        {
            int max = random.Next(0, 50);
            stateOut = "";
            for (int n = 0; n < NoOfCars; n++)
            {
                positions[n].X += random.Next(0, max);
                if (positions[n].X + carTextures[n].Width > GameMain.ScreenWidth - 40)
                {
                    if (!winstates[n])
                    {
                        winnerCount++;
                        stateOut = $"{carReports[n]} {gameTime.ElapsedGameTime.TotalMilliseconds} ms \n";
                        winstates[n] = true;
                    }
                }
            }

            if (winnerCount == NoOfCars)
            {
                GameElement.carSoundInstance.Stop();
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int n = 0; n < NoOfCars; n++)
            {
                spriteBatch.Draw(carTextures[n], positions[n], Color.White);
                if (winstates[n])
                {
                    if (!reported[n])
                    {
                        statesOut += $"{winnerCount} {stateOut}";
                        reported[n] = true;
                    }
                    spriteBatch.DrawString(stateFont, statesOut, new Vector2(GameMain.ScreenWidth / 3, 40), Color.Black);
                }
            }
        }
    }
}
