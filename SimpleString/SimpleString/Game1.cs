using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleString
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont gameFont;
        private Texture2D balloonRed;
        private Texture2D balloonYellow;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        // this is where i can change initial settings
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1024;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            gameFont = Content.Load<SpriteFont>("File");
            balloonRed = Content.Load<Texture2D>("b1");
            balloonYellow = Content.Load<Texture2D>("b2");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            _spriteBatch.Begin();
            _spriteBatch.DrawString(gameFont, "what", new Vector2(0,0), Color.Blue);
            _spriteBatch.DrawString(gameFont, "what", new Vector2(0,20), Color.Black);
            _spriteBatch.Draw(balloonRed, new Vector2(40, 40), Color.White);
            _spriteBatch.Draw(balloonYellow, new Vector2(80, 40), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
