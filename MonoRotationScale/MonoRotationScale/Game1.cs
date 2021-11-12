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
            gameEntity.name = images[0];
            gameEntity.position = new Vector2(
                _graphics.PreferredBackBufferWidth / 2, 
                _graphics.PreferredBackBufferHeight / 2);

            gameText = new GameText();
            gameText.name = "rotationFont";
            gameText.position = new Vector2(
                _graphics.PreferredBackBufferWidth - 300, 
                _graphics.PreferredBackBufferHeight - 30);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // loading classes
            gameEntity.Load(Content);
            gameText.Load(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // comes classes
            gameEntity.Update();
            gameText.text = ($"Rotation: {gameEntity.rotation}");

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            // comes from classes
            gameEntity.Draw(_spriteBatch);
            gameText.Draw(_spriteBatch);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
