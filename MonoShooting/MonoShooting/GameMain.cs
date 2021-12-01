using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoShooting
{
    public class GameMain : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        int screenWidth = 1700;
        int screenHeight =1000;


        // sprites
        Texture2D biker;
        Texture2D skyBackground;


        public GameMain()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = screenWidth;
            _graphics.PreferredBackBufferHeight = screenHeight;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            skyBackground = Content.Load<Texture2D>("Assets/sky");
            biker = Content.Load<Texture2D>("Assets/Biker/Biker_idle");
            
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(skyBackground, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(biker, new Vector2(30, 30), Color.White);
            Rectangle rec = new Rectangle(0, 0, 48, 48);
            Rectangle rec1 = new Rectangle(1, 1, 48, 48);
            Rectangle rec2 = new Rectangle(2, 2, 48, 48);
            Rectangle rec3 = new Rectangle(3, 3, 48, 48);
            _spriteBatch.Draw(biker, new Vector2(50, 50), rec, Color.White);
            _spriteBatch.Draw(biker, new Vector2(150, 50), rec1, Color.White);
            _spriteBatch.Draw(biker, new Vector2(250, 50), rec2, Color.White);
            _spriteBatch.Draw(biker, new Vector2(350, 50), rec3, Color.White);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
