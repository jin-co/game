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

        public static void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                GameSprites.LoadSprite("Sprites/maps/Map_tile_01"), 
                new Vector2(x, y), 
                Color.White);
            x++;
            y++;
        }
    }
}
