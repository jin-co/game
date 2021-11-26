using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoChrismas
{
    class SnowFlake
    {
        private Texture2D _snowSprite;
        public float opacity;
        private Vector2 _origin;
        public float scale;
        public Vector2 velocity;
        public Vector2 position;
        public bool removed = false;
        public int striteHeight;
        public float rotation;

        public SnowFlake(Texture2D snowSprite)
        {
            _snowSprite = snowSprite;
            opacity = 1.0f;
            _origin = new Vector2(_snowSprite.Width / 2, _snowSprite.Height / 2);
        }

        public void Update(GameTime gameTime)
        {
            position += velocity;
            if (position.Y > GameMain.screenWidth)
            {
                removed = true;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_snowSprite, position, null, Color.White * opacity, rotation, _origin, scale, SpriteEffects.None, 0);
        }

        public SnowFlake Clone()
        {
            // shallow copy
            return (SnowFlake)this.MemberwiseClone();
        }
    }
}
