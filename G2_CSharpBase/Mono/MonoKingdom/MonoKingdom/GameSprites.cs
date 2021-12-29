using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoKingdom
{
    class GameSprites
    {
        public static ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }

        public GameSprites(ContentManager content, Texture2D sprite)
        {
            Content = content;            
        }

        public static Texture2D LoadSprite(string fileName)
        {
            return Content.Load<Texture2D>(fileName);
        }
    }
}
