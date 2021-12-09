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
        #region Properties
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public Vector2 Position { get; set; }
        public int Radius { get; set; }
        #endregion

        #region Contructors
        public Box(ContentManager content)
        {
            Content = content;
            Position = new Vector2(50, 680);
            Radius = 10;
        }
        #endregion

        public void Load()
        {
            Sprite = Content.Load<Texture2D>("Assets/box");
        }

        public void Draw(GameTime gameTimer, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, Position, Color.White);
        }
    }
}
