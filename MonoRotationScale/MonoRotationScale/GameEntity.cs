using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoRotationScale
{
    class GameEntity
    {
        private Texture2D entity;
        private Vector2 origin;
        private float scale = 0.5f;
        private float scaleChange = 0.01f;
        private Rectangle sourceRectangle;
        private float rotationChange = 0.03f;
        private const float MIN_SCALE = 0.1f;
        private const float MAX_SCALE = 2.0f;

        public float Rotation;
        public string Name;
        public Vector2 Position;

        public void Load(ContentManager Content)
        {
            entity = Content.Load<Texture2D>(Name);
            origin = new Vector2(entity.Width / 2, entity.Height / 2);
            sourceRectangle = new Rectangle(0, 0, entity.Width, entity.Height);
        }

        public void Update()
        {
            Rotation += rotationChange;
            scale += scaleChange;
            if ((scale > MAX_SCALE) || (scale < MIN_SCALE))
            {
                scaleChange = -scaleChange;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(entity, Position, sourceRectangle, Color.White, Rotation, origin, scale, SpriteEffects.None, 0f);
        }
    }
}
