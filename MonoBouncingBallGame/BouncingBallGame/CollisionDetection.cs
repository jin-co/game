using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BouncingBallGame
{
    class CollisionDetection
    {
        private Ball ball;
        private Bat bat;
        private SoundEffect hitSound;
        private Explosion explosion;

        public CollisionDetection (Ball ball, Bat bat, SoundEffect hitSound, Explosion explosion)
        {
            this.ball = ball;
            this.bat = bat;
            this.hitSound = hitSound;
            this.explosion = explosion;
        }

        public void Update (GameTime gameTime)
        {
            if (ball.GetBound().Intersects (bat.GetBound()))
            {
                ball.speed.Y = -Math.Abs(ball.speed.Y);
                hitSound.Play();

                explosion.Position = new Vector2 (ball.GetBound().X - ball.GetBound().Width /2, 
                                                  ball.GetBound().Y - ball.GetBound().Height / 2);
                // start the animation
                explosion.Enable = true;
            }
        }
    }
}
