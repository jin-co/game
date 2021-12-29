using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // box class that controls box
    class Box
    {
        #region Fields
        private Texture2D _sprite;
        #endregion

        #region Properties        
        public Vector2 Position { get; set; }
        public int Radius { get; set; }
        #endregion

        #region Contructors
        public Box()
        {
            Position = new Vector2(50, 680);
            Radius = 10;
        }
        #endregion

        public void Load()
        {
            _sprite = GameSpriteLoader.Load("Assets/box");
        }

        public void Draw(GameTime gameTimer, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite, Position, Color.White);
        }
    }
}
