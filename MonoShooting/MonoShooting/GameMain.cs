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
        int screenHeight = 950;


        // sprites
        Texture2D bikerSprite;
        Texture2D skyBackground;
        Texture2D ground;
        Texture2D bullet;
        Texture2D collisionEffectSprite;

        //test
        List<Rectangle> rectangles;
        int num = -1;

        //test
        Biker biker;

        //test
        GameController controller = new GameController();
        Vector2 collisionPoint;

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //skyBackground = Content.Load<Texture2D>("Assets/sky");
            ground = Content.Load<Texture2D>("Assets/ground");
            biker.BikerLoad();
            bullet = Content.Load<Texture2D>("Assets/Enemies/bullet");
            collisionEffectSprite = Content.Load<Texture2D>("Assets/effect_collision");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // biker move
            biker.BikerUpdate(gameTime);
            controller.Update(gameTime);

            foreach (var i in controller.bullets)
            {
                i.BulletUpdate(gameTime);

                if (Vector2.Distance(i.position, biker.Position) < i.radius + biker.Radius)
                {
                    controller.GameOver = true;
                    collisionPoint = new Vector2(i.position.X - i.radius, i.position.Y - i.radius);
                }
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(ground, new Vector2(0, 0), Color.White);

            //test
            biker.Draw(gameTime, _spriteBatch);
            foreach (var i in controller.bullets)
            {
                _spriteBatch.Draw(bullet, new Vector2(i.position.X, i.position.Y + i.radius), Color.White);
            }

            if (controller.GameOver)
            {
                _spriteBatch.Draw(collisionEffectSprite, collisionPoint, Color.White);

            }

            //_spriteBatch.Draw(biker, new Vector2(50, 50), rectangles[num], Color.White);



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
