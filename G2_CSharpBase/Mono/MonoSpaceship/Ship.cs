using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    class Ship
    {
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 test = defaultPosition;
        public int speed = 180;
        public int radius = 30;

        // properties
        public Vector2 Position { get; set; }

        // constructors
        public Ship() {}

        public Ship(Vector2 position)
        {
            Position = position;
        }

        // ship motion method
        public void shipUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();

            // a variable to hold the time between frames
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            /* by multiplying speed by 'dt', the object now moves 
             * at the set speed every second(before it was moving
             * at the set speed every frame -> much faster ->
             * needs an adjustment -> just set the speed at a higher rate)
             */

            if (kState.IsKeyDown(Keys.Right) && test.X < 1280) {test.X+= speed * dt;}
            
            if (kState.IsKeyDown(Keys.Left) && test.X > 0) {test.X-= speed * dt; }
            
            if (kState.IsKeyDown(Keys.Down) && test.Y < 720) {test.Y+= speed * dt; }
            
            if (kState.IsKeyDown(Keys.Up) && test.Y > 0) {test.Y-= speed * dt; }
            
        }
    }
}
