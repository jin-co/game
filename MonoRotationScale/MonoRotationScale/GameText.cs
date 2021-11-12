using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoRotationScale
{
    class GameText
    {
        private Texture2D entiry;
        private Vector2 origin;
        private float scale = 0.5f;
        private float scaleChange = 0.01f;
        private Rectangle sourceRectangle;
        public float rotation;
        private float rotationChange = 0.03f;
    }
}
