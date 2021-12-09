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
        #region Properties
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public Vector2 Position { get; set; }
        public int Radius { get; set; }
        #endregion

        #region Constructors
        public Ladder(ContentManager content)
        {
            Content = content;
            Position = new Vector2(1300, 730);
            Radius = 68; 
        }
        #endregion

        public void Load()
        {
            Sprite = Content.Load<Texture2D>("Assets/ladder");
        }

        public void Draw(GameTime gameTimer, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, Position, Color.White);
        }
    }
}
