using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpAboutMenu
{
    class SpriteElement
    {
        protected ContentManager Content;
        protected Texture2D sprite; // image
        protected Vector2 origin;
        public int Width, Height;
        public Rectangle BoundingBox;
        public Vector2 Position;

        public SpriteElement (ContentManager content)
        {
            Content = content;
        }

        public Texture2D Load (string name)
        {
            sprite = Content.Load<Texture2D>(name);
            Width = sprite.Width;
            Height = sprite.Height;
            return sprite;
        }

        // game  loop
        public virtual void Update ()
        {

        }
        // game loop
        public void Draw (GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, Position, Color.White);

        }
 
        public virtual void Reset ()
        {

        }
    }
}
