using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Spaceship
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // variable for the assets
        Texture2D shipSprite;
        Texture2D asteroidSprite;
        Texture2D spaceSprite;
        SpriteFont gameFont;
        SpriteFont timerFont;

        // creating instances
        Ship player = new Ship(new Vector2(100, 100));
        //Asteroid asteroid = new Asteroid();
        Controller gameController = new Controller();

        // setting the initial position

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // changing screen size 
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges(); // without this changes won't show 

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            shipSprite = Content.Load<Texture2D>("ship");
            asteroidSprite = Content.Load<Texture2D>("asteroid");
            spaceSprite = Content.Load<Texture2D>("space");
            gameFont = Content.Load<SpriteFont>("spaceFont");
            timerFont = Content.Load<SpriteFont>("timerFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // ship motions
            if (gameController.inGame) player.shipUpdate(gameTime);
            gameController.conUpdate(gameTime);
            //player.Position.X++; --> why dose it throw an error?

            // asteroid motion
            //asteroid.asteroidUpdate(gameTime);

            // calling all the asteroid
            foreach (var i in gameController.asteroids)
            {
                i.asteroidUpdate(gameTime);

                // implementing a collision
                int sum = i.radius + player.radius;
                if (Vector2.Distance(i.position, player.test) < sum)
                {
                    gameController.inGame = false;
                    player.test = Ship.defaultPosition;
                    gameController.asteroids.Clear(); // fix this
                }
            }

            //for (int i = 0; i < gameController.asteroids.Count; i++)
            //{
            //    gameController.asteroids[i].asteroidUpdate(gameTime);
            //}

            /* for the ship to move at the same speed no matter what the 
             * frame rate is, pass the gameTiem to the method */
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // drawing
            _spriteBatch.Begin();
            _spriteBatch.Draw(spaceSprite, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(shipSprite,
                new Vector2(player.test.X - 34, 
                player.test.Y - 50), 
                Color.White);
            foreach (var i in gameController.asteroids)
            {
                _spriteBatch.Draw(asteroidSprite,
                new Vector2(i.position.X - i.radius,
                i.position.Y - i.radius),
                Color.White);
            }
            //for (int i = 0; i < gameController.asteroids.Count; i++)
            //{
            //    _spriteBatch.Draw(asteroidSprite,
            //    new Vector2(gameController.asteroids[i].position.X - gameController.asteroids[i].radius,
            //    gameController.asteroids[i].position.Y - gameController.asteroids[i].radius),
            //    Color.White);
            //}

            if (!gameController.inGame)
            {
                string menuMessage = "Press Enter to begin";
                /* get the size of the text to make an adjustment below when 
                 * when making the text actually centered */
                Vector2 sizeOfText = gameFont.MeasureString(menuMessage);
                int halfWidth = _graphics.PreferredBackBufferWidth / 2;
                _spriteBatch.DrawString(gameFont, menuMessage, new Vector2(halfWidth - sizeOfText.X / 2, 200), Color.White);
            }

            // timer
            _spriteBatch.DrawString(timerFont, 
                "Time: " + Math.Floor(gameController.totalTime), 
                new Vector2(3, 3), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
