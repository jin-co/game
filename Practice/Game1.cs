using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Practice
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D targetSprite;
        Texture2D crosshairsSprite;
        Texture2D skySprite;

        SpriteFont gameFont;

        Target target = new Target();

        MouseState mState;

        int score = 0;

        double timer = 10;
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            skySprite = Content.Load<Texture2D>("sky");
            targetSprite = Content.Load<Texture2D>("target");
            crosshairsSprite = Content.Load<Texture2D>("crosshairs");
            gameFont = Content.Load<SpriteFont>("galleryFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // timer
            if (timer > 0) timer -= gameTime.ElapsedGameTime.TotalSeconds;
            if (timer < 0) timer = 0; 
            
            // mouse position
            mState = Mouse.GetState();

            // score
            float mouseTargetDist = Vector2.Distance(target.Position, mState.Position.ToVector2());
            




            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            target.Position = new Vector2(300, 300);
            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(skySprite, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(targetSprite, 
                new Vector2(
                    target.Position.X - target.getTargetRadius(), 
                    target.Position.Y - target.getTargetRadius()
                    ), 
                Color.White);
            _spriteBatch.Draw(crosshairsSprite, 
                new Vector2(mState.X - 24, mState.Y - 24), 
                Color.Red);

            // score
            _spriteBatch.DrawString(gameFont,
                "Score: " + score.ToString(),
                new Vector2(10, 10),
                Color.White);
            // timer
            _spriteBatch.DrawString(gameFont,
                "timer: " + Math.Floor(timer).ToString(),
                new Vector2(10, 50),
                Color.White);

            // test
            _spriteBatch.DrawString(gameFont, "mState" + mState.Position.ToVector2().ToString(), new Vector2(10, 150), Color.White);
            _spriteBatch.DrawString(gameFont, "target X: " + target.Position.X.ToString(), new Vector2(10, 250), Color.White);
            _spriteBatch.DrawString(gameFont, "target Y: " + target.Position.Y.ToString(), new Vector2(10, 350), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
