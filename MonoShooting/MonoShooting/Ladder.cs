using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Ladder
    {
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public Vector2 Position { get; set; }
        public int Radius { get; set; }

        public Ladder(ContentManager content)
        {
            Content = content;
            Position = new Vector2(1300, 730);
            Radius = 68; //width 24
        }

        public void Load()
        {
            Sprite = Content.Load<Texture2D>("Assets/ladder");
        }

        public void Update(GameTime gameTimer)
        {

        }

        public void Draw(GameTime gameTimer, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, Position, Color.White);
        }


    }
}
