using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoChrismas
{
    class GameElements
    {
        private SnowGenerator _snowGenerate;
        private Texture2D _chrismas;
        private Texture2D _snowSprite;
        private SpriteFont _gameFont;
        private SnowFlake _snowFlake;
        private Color _txtColor = Color.Yellow;

        private Vector2 cardPosition = Vector2.Zero;
        private Vector2 cardSpeed = new Vector2(1, 1);
        private Vector2 txtPosition = new Vector2(30, 10);
        private Vector2 txtSpeed = new Vector2(1, 1);

        public void Load(ContentManager content)
        {
            _snowSprite = content.Load<Texture2D>("snowflake16");
            _snowFlake = new SnowFlake(_snowSprite);
            _snowFlake.striteHeight = _snowSprite.Height;
            _snowGenerate = new SnowGenerator(_snowFlake);
            _chrismas = content.Load<Texture2D>("christmas");
            _gameFont = content.Load<SpriteFont>("gameFont");
            Song song = content.Load<Song>("NatKingCole");
            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(song);
        }

        public void Update(GameTime gameTime)
        {
            _snowGenerate.Update(gameTime);
            cardPosition += cardSpeed;

            if (cardPosition.X >= GameMain.screenWidth / 2)
            {
                cardSpeed.X = -Math.Abs(cardSpeed.X);
            }
            else if (cardPosition.X <= 0)
            {
                cardSpeed.X = Math.Abs(cardSpeed.X);
            }

            if (cardPosition.Y >= GameMain.screenHeight / 2)
            {
                cardSpeed.Y = -Math.Abs(cardSpeed.Y);
            }
            else if (cardPosition.Y <= 0)
            {
                cardSpeed.Y = Math.Abs(cardSpeed.Y);
            }

            txtPosition += txtSpeed;
            //add logic if you want to move text as well

        }

        private string message = "Happy Christmas, PROG2370 Class!";
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            _snowGenerate.Draw(gameTime, spriteBatch);
            spriteBatch.Draw(_chrismas, cardPosition, Color.White);
            spriteBatch.DrawString(_gameFont, message, txtPosition, _txtColor);
            spriteBatch.End();
        }
    }
}
