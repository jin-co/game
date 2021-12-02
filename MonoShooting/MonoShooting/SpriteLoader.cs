using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class SpriteLoader
    {
        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }

        public SpriteLoader(ContentManager content)
        {
            Content = content;
        }

        public Texture2D Load(string fileName)
        {
            Sprite = Content.Load<Texture2D>(fileName);
            return Sprite;
        }
    }
}
