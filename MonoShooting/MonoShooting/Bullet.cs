using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Bullet
    {
        public Vector2 position = new Vector2(600, 300);
        public int speed;
        public int radius = 3;

        public Bullet()
        {
            Random random = new Random();
            this.speed = 200;
            this.position = new Vector2(1400, random.Next(795, 950));
        }        

        public void BulletUpdate(GameTime gameTime)
        {
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * elapsedTime;
        }
    }
}
