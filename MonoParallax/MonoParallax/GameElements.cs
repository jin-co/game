using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoParallax
{
    class GameElements
    {
        private List<ParallaxLayers> _parallaxLayers;
        private Player _player;

        public void Load(ContentManager content)
        {
            string[] spriteNames =
            {
                "sky",
                "slow",
                "back",
                "fast",
                "middle",
                "front",
                "floor",
                "trees"
            };

            float[] speedX =
            {
                0f,
                0.3f,
                0.6f,
                1f,
                2f,
                3f,
                4f,
                5f
            };

            float[] layers =
            {
                0f,
                0.1f,
                0.2f,
                0.3f,
                0.4f,
                0.5f,
                0.6f,
                0.7f
            };

            _parallaxLayers = new List<ParallaxLayers>();
            for (int i = 0; i < layers.Length; i++)
            {
                ParallaxLayers layer = new ParallaxLayers(content);
                layer.Load(spriteNames[i]);
                layer.speedX = speedX[i];
                layer.layer = layers[i];
                _parallaxLayers.Add(layer);
            }

            _player = new Player(content);
            _player.layer = 1f;
        }

        // game loop
        public void Update(GameTime gameTime)
        {
            _player.Update(gameTime);
            foreach (var i in _parallaxLayers)
            {
                i.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            _player.Draw(gameTime, spriteBatch);
            foreach (var i in _parallaxLayers)
            {
                i.Draw(gameTime, spriteBatch);
            }
            spriteBatch.End();
        }
    }
}
