using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoKingdom
{  
    class Map
    {
        private static int x = 0;
        private static int y = 0;

        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch, Vector2 point)
        {
            spriteBatch.Draw(
            GameSprites.LoadSprite("Sprites/maps/Map_tile_01"),
            point,
            Color.White);
        }
    }
}
