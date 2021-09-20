using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Practice
{
    class Target
    {
        public Target() {}

        private const int TARGET_RADIUS = 45;

        public Vector2 Position { get; set; }
       
        public int getTargetRadius()
        {
            return TARGET_RADIUS;
        }
    }
}
