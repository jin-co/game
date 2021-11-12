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
        private SpriteFont rotationFont;
        public Vector2 position;
        public Color color = Color.Red;
        public string text;
        public string name;

        public void Load(ContentManager content)
        {
            rotationFont = content.Load<SpriteFont>(name);
        }

        public void Update()
        {
            // as we have a property Text we can replace this part for this 
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(rotationFont, text, position, color);
        }
    }
}
