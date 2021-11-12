using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoRotationScale
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameEntity gameEntity;
        private GameText gameText;
        private string[] images = {"coin", "dollar", "dna", "earth"};

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            gameEntity = new GameEntity();
            gameText = new GameText();
            gameEntity.name = images[0];
            gameEntity.position = 
                new Vector2(
                    _graphics.PreferredBackBufferWidth / 2, 
                    _graphics.PreferredBackBufferHeight / 2);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            gameEntity.Load(Content);
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // comes from gameEntity class
            gameEntity.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            // comes from gameEntity clasee
            gameEntity.Draw(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
