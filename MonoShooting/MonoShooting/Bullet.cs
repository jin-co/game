using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // bullet class that controls bullet
    class Bullet
    {
        #region Fields
        public Vector2 position = new Vector2(600, 300);
        public int speed;
        #endregion

        #region Properties
        public int Radius { get; set; }
        #endregion

        #region Constructors
        public Bullet()
        {
            Random random = new Random();
            this.speed = 200;
            this.position = new Vector2(1400, random.Next(795, 950));
            Radius = 3;
        }
        #endregion

        public void BulletUpdate(GameTime gameTime)
        {
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * elapsedTime;
        }
    }
}
