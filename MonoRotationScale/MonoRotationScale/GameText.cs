using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoRotationScale
{
    class GameText
    {
        private Texture2D entity;
        private Vector2 origin;
        private float scale = 0.5f;
        private float scaleChange = 0.01f;
        private Rectangle sourceRectangle;
        private float rotationChange = 0.03f;
        private const float MIN_SCALE = 0.1f;
        private const float MAX_SCALE = 2.0f;

        public float rotation;
        public string name;

        public void Load(ContentManager content)
        {
            entity = content.Load<Texture2D>(name);
            origin = new Vector2(entity.Width / 2, entity.Height / 2);
            sourceRectangle = new Rectangle(0, 0, entity.Width, entity.Height);
        }

        public void Update()
        {
            rotation += rotationChange;
            scale += scaleChange;
            if (scale > MAX_SCALE || scale < MIN_SCALE)
            {
                scaleChange = -scaleChange;
            }
        }

    }
}
