using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoMenu
{
    class SpriteElement
    {
        protected ContentManager content;
        protected Texture2D sprite;
        protected Vector2 origin;
        public int width, height;
        public Rectangle boundingBox;
        public Vector2 position;

        public SpriteElement(ContentManager content)
        {
            this.content = content;
        }

        public void Update()
        {

        }

        public Texture2D Load(string name)
        {
            sprite = content.Load<Texture2D>(name);
            width = sprite.Width;
            height = sprite.Height;
            return sprite;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, Color.White);
        }

        public virtual void Reset()
        {

        }
    }
}
