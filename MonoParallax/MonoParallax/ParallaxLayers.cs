using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoParallax
{
    class ParallaxLayers
    {
        private ContentManager _content;
        private Texture2D _sprite1, _sprite2;
        private Vector2 _position1, _position2;
        private bool _currentIsFirst = true;
        private bool _moveLeft = true;
        public float speedX;
        public float layer;

        public ParallaxLayers(ContentManager content)
        {
            _content = content;
        }

        public void Load(string spriteName)
        {
            Texture2D sprite = _content.Load<Texture2D>(spriteName);
            _sprite1 = sprite;
            _sprite2 = sprite;
            _position1 = Vector2.Zero;

            if (_moveLeft)
            {
                _position2 = new Vector2(GameMain.screenWidth, 0);
            }
            else
            {
                _position2 = new Vector2(-GameMain.screenWidth, 0);
            }
        }

        // game loop
        public void Update(GameTime gameTime)
        {
            if (_moveLeft)
            {
                _position1.X -= speedX;
                _position2.X -= speedX;


            }
        }
    }
}
