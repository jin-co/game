using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoCarRace
{
    class GameElement
    {
        private SoundEffect carSound;
        public static SoundEffectInstance carSoundInstance;
        private Song music;

        private Texture2D finishLine;
        private Texture2D background;
        private SpriteFont gameFont;

        private CarSet cars;

        public GameElement(ContentManager Content)
        {
            background = Content.Load<Texture2D>("road");
            finishLine = Content.Load<Texture2D>("finishline");
            gameFont = Content.Load<SpriteFont>("gamefont");
            carSound = Content.Load<SoundEffect>("car");
            carSoundInstance = carSound.CreateInstance();
            music = Content.Load<Song>("music");
            //MediaPlayer.Play(music);
            //MediaPlayer.IsRepeating = true;

            cars = new CarSet(Content);
        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                cars.StartGame();
            }
            else
            {
                cars.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, null, Color.White, 0.0f, Vector2.Zero, 0.65f, SpriteEffects.None, 0);
            //  spriteBatch.Draw(redBalloon, Vector2.Zero, null, Color.White, 0.0f, Vector2.Zero, 0.25f, SpriteEffects.None, 0);

            spriteBatch.Draw(finishLine, new Vector2(GameMain.ScreenWidth - 20, 0), Color.White);
            spriteBatch.DrawString(gameFont, "Press Enter Key to Start Over", new Vector2(GameMain.ScreenWidth / 3, GameMain.ScreenHeight - 40), Color.Black);
            cars.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }
    }
}
