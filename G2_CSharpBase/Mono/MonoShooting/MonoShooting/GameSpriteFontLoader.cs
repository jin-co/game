﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class GameSpriteFontLoader
    {
        public static ContentManager Content { get; set; }
        private static SpriteFont SpriteFont { get; set; }

        public GameSpriteFontLoader(ContentManager content)
        {
            Content = content;
        }

        public static SpriteFont Load(string fileName)
        {
            SpriteFont = Content.Load<SpriteFont>(fileName);
            return SpriteFont;
        }
    }
}
