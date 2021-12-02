using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Bullet : SpriteLoader
    {
        public Vector2 position = new Vector2(600, 300);
        public int speed;
        public int radius = 59;
        public List<Bullet> bullets;

        public Bullet(ContentManager content) : base(content)
        {
            Random random = new Random();
            this.speed = 200;
            this.position = new Vector2(1200, random.Next(700));
            bullets = new List<Bullet> { };
        }

        public Texture2D BulletLoad()
        {
            Sprite = Content.Load<Texture2D>("Assets/Biker/Biker_punch");
            return Sprite;
        }

        public void BulletUpdate(GameTime gameTime)
        {
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * elapsedTime;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, position, Color.White);
        }

    }
}
