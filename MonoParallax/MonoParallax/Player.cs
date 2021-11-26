using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoParallax
{
    class Player
    {
        private Texture2D _playerSprite;
        private Vector2 _position;
        private int _speedX;
        public float layer;

        public Player(ContentManager content)
        {
            _playerSprite = content.Load<Texture2D>("player");
            _position = new Vector2(5, GameMain.screenHeight - _playerSprite.Height - 5);
        }

        // game loop
        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                _speedX = 4;
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                _speedX = -4;
            }
            else
            {
                _speedX = 0;
            }

            // boundary setting
            _position.X += _speedX;

            if (_position.X < -5)
            {
                _position.X = GameMain.screenWidth;
            }

            _position.X %= GameMain.screenWidth;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_playerSprite, _position, null, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, layer);

        }
    }
}
