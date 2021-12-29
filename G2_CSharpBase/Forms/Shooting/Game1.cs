using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Shooting
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        // spriteBatch is a tool that monogame provides for us to draw
        private SpriteBatch _spriteBatch;

        // Texture is a two dimensional image(sprite)
        Texture2D targetSprite;
        Texture2D crosshairsSprite;
        Texture2D backgroundSprite;

        SpriteFont gameFont;

        Vector2 targetPosition = new Vector2(300, 300);
        const int TARGET_RADIUS = 45; // use const generously for constant values

        // MouseState class
        MouseState mState;
        bool mRealsed = true;

        int score = 0;

        //timer
        double timer = 10;

        /// <summary>
        /// constructor -> handles the basic settings for the game
        /// </summary>
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            // making mouse invisible -> default: visible(true)
            IsMouseVisible = false;
        }

        /// <summary>
        /// loads a certain services
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// lets us include art assets
        /// </summary>
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // content.load -> monogame function that lets us to load assets from content folder
            // here when i say 'target' editor knows that i am referring to 'target.xnb'
            targetSprite = Content.Load<Texture2D>("target");
            crosshairsSprite = Content.Load<Texture2D>("crosshairs");
            backgroundSprite = Content.Load<Texture2D>("sky");
            gameFont = Content.Load<SpriteFont>("galleryFont");
        }

        /// <summary>
        /// updates 60 frames a sec(constant game loop) -> like a interval in js
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // setting a timer
            if (timer > 0)
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (timer < 0)
            {
                timer = 0;
            }

            mState = Mouse.GetState();
            if (mState.LeftButton == ButtonState.Pressed && mRealsed)
            {
                // find the coordinates of the mouse and the target
                float mouseTargetDist = Vector2.Distance(targetPosition, mState.Position.ToVector2());
                if (mouseTargetDist < TARGET_RADIUS && timer > 0)
                {
                    score++;

                    Random random = new Random();
                    targetPosition.X = random.Next(0, _graphics.PreferredBackBufferWidth); // max num is not inclusive(random)
                    targetPosition.Y = random.Next(0, _graphics.PreferredBackBufferHeight);
                }
                mRealsed = false;
            }

            if (mState.LeftButton == ButtonState.Released)
            {
                mRealsed = true;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// this also run every second but it is better to use only for drawing
        /// </summary>
        /// <param name="gameTime"></param>
        protected override void Draw(GameTime gameTime)
        {
            /// keep in mind that drawing has an order from top further from the user to the bottom
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundSprite, new Vector2(0, 0), Color.White);
            // score
            _spriteBatch.DrawString(gameFont, 
                "Score: " + score.ToString(), 
                new Vector2(_graphics.PreferredBackBufferWidth - 150, 
                3), Color.White);
            // timer
            _spriteBatch.DrawString(gameFont, 
                "Time: " + Math.Ceiling(timer).ToString(), 
                new Vector2(_graphics.PreferredBackBufferWidth - 150, 
                40), Color.White);

            // shows the target only when the timer is greater than 0
            if (timer > 0)
            {
                // making the target a variable to manipulate its coordinates
                _spriteBatch.Draw(targetSprite, new Vector2(targetPosition.X - TARGET_RADIUS, targetPosition.Y - TARGET_RADIUS), Color.White);
            }

            // adding arrow(here again keep in mind the flow of the screen)
            _spriteBatch.Draw(crosshairsSprite, 
                new Vector2(mState.X - 25, mState.Y - 25), Color.White);


            /// for testing
            _spriteBatch.DrawString(gameFont, targetPosition.X.ToString(), new Vector2(10, 0), Color.White);
            _spriteBatch.DrawString(gameFont, targetPosition.Y.ToString(), new Vector2(10, 50), Color.White);
            _spriteBatch.DrawString(gameFont, TARGET_RADIUS.ToString(), new Vector2(10, 100), Color.White);
            _spriteBatch.DrawString(gameFont, mState.Position.ToVector2().ToString(), new Vector2(10, 150), Color.White);

            //_spriteBatch.Draw(targetSprite, new Vector2(0, 0), Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
