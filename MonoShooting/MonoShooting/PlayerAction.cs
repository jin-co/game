using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class PlayerAction : SpriteLoader
    {
        public PlayerAction(ContentManager content) : base(content)
        {
        }

        public List<Rectangle> Rectangles { get; set; }
    }
}
