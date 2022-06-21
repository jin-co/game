using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Spaceship
{
    class Asteroid
    {
        public Vector2 position = new Vector2(600, 300);
        public int speed;
        public int radius = 59;

        public Asteroid() {}

        public Asteroid(int speed)
        {
            Random random = new Random();
            this.speed = speed;
            this.position = new Vector2(1280, random.Next(721));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
