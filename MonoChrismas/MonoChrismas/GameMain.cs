using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoChrismas
{
    public class GameMain : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static int screenWidth = 1700;
        public static int screenHeight = 1200;

        private GameElements gameElements;
        private Color color = Color.Red;
        private Color[] colors = { Color.Red, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGreen };
        private int colorIndex = 0;

        public GameMain()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = screenWidth;
            _graphics.PreferredBackBufferHeight = screenHeight;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        private int n = 1;
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            gameElements.Update(gameTime);

            if (gameTime.TotalGameTime.TotalSeconds > 5 * n)
            {
                n++;
                color = colors[colorIndex];
                colorIndex++;
                colorIndex %= colors.Length;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(color);

            // TODO: Add your drawing code here
            gameElements.Draw(gameTime, _spriteBatch);

            base.Draw(gameTime);
        }
    }
}
