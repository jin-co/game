﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class GameSpriteLoader
    {
        public static ContentManager Content { get; set; }
        private static Texture2D Sprite { get; set; }

        public GameSpriteLoader(ContentManager content)
        {
            Content = content;            
        }

        public static Texture2D Load(string fileName)
        {
            Sprite = Content.Load<Texture2D>(fileName);
            return Sprite;
        }
    }
}
