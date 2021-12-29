using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // ladder class that controls the ladder
    class Ladder
    {
        #region Fields
        private Texture2D _sprite;
        #endregion

        #region Properties        
        public Vector2 Position { get; set; }
        public int Radius { get; set; }
        #endregion

        #region Constructors
        public Ladder()
        {
            Position = new Vector2(1300, 730);
            Radius = 68; 
        }
        #endregion

        public void Load()
        {
            _sprite = GameSpriteLoader.Load("Assets/ladder");
        }

        public void Draw(GameTime gameTimer, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite, Position, Color.White);
        }
    }
}
