using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace MonoShooting
{
    public class GameMain : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        int screenWidth = 1400;
        int screenHeight =950;


        // sprites
        Texture2D bikerSprite;
        Texture2D skyBackground;
        Texture2D ground;

        //test
        List<Rectangle> rectangles;
        int num = -1;

        //test
        Biker biker;
        Bullet bullet;

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

            biker = new Biker(Content);
            bullet = new Bullet(Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //skyBackground = Content.Load<Texture2D>("Assets/sky");
            ground = Content.Load<Texture2D>("Assets/ground");
            biker.BikerLoad();
            bullet.BulletLoad();

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // biker move
            biker.BikerUpdate(gameTime);
            bullet.BulletUpdate(gameTime);
            
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(ground, new Vector2(0, 0), Color.White);

            //test
            biker.Draw(gameTime, _spriteBatch);
            bullet.Draw(gameTime, _spriteBatch);

            //_spriteBatch.Draw(biker, new Vector2(50, 50), rectangles[num], Color.White);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
