using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoMenu
{
    class SpriteElements
    {
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle BoundingBox { get; set; }
        public Vector2 Position { get; set; }

        public SpriteElements(ContentManager content)
        {
            Content = content;
        }

        public Texture2D Load(string name)
        {
            Sprite = Content.Load<Texture2D>(name);
            return Sprite;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, Position, Color.White);
        }
    }
}
