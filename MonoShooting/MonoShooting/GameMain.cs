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
        Texture2D gameoverSprite;
        Texture2D gameoverBackSprite;
        Texture2D ladderSprite;
        Texture2D ground;
        Texture2D bullet;
        Texture2D collisionEffectSprite;        
       
        //test
        Biker biker;
        Page page;

        //test
        GameController controller = new GameController();
        Vector2 collisionPoint;

        //test
        KeyboardState kState;

        double timer = 1;

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
            page = new Page(Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            ground = Content.Load<Texture2D>("Assets/ground");
            biker.BikerLoad();
            bullet = Content.Load<Texture2D>("Assets/Enemies/bullet");
            collisionEffectSprite = Content.Load<Texture2D>("Assets/effect_collision");
            ladderSprite = Content.Load<Texture2D>("Assets/ladder");
            gameoverBackSprite = Content.Load<Texture2D>("Assets/gameover_back");
            gameoverSprite = Content.Load<Texture2D>("Assets/gameover");            
            page.Load();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            if (!GameController.StartGame)
            {
                page.PageUpdate(gameTime);
            }
            else
            {
                if (!GameController.GameOver)
                {
                    biker.BikerUpdate(gameTime);
                    controller.Update(gameTime);

                    foreach (var i in controller.bullets)
                    {
                        i.BulletUpdate(gameTime);

                        if (Vector2.Distance(i.position, biker.Position) < i.radius + biker.Radius)
                        {                            
                            biker.Dead = true;
                            biker.BikerUpdate(gameTime);
                            collisionPoint = new Vector2(i.position.X - i.radius, i.position.Y - i.radius);                            
                        }
                    }
                }
                else
                {
                    biker.BikerUpdate(gameTime);
                }
            }        

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // main page
            if (!GameController.StartGame)
            {
                page.Draw(gameTime, _spriteBatch);
            }

            //game play
            if (GameController.StartGame)
            {
                _spriteBatch.Draw(ground, new Vector2(0, 0), Color.White);

                //test
                biker.Draw(gameTime, _spriteBatch);
                foreach (var i in controller.bullets)
                {
                    _spriteBatch.Draw(bullet, new Vector2(i.position.X, i.position.Y + i.radius), Color.White);
                }

                _spriteBatch.Draw(ladderSprite, new Vector2(1300, 730), Color.White);

                if (GameController.GameOver)
                {
                    _spriteBatch.Draw(collisionEffectSprite, collisionPoint, Color.White);

                    timer -= gameTime.ElapsedGameTime.TotalSeconds;
                    if (timer <= 0.5)
                    {
                        _spriteBatch.Draw(gameoverBackSprite, new Vector2(0, 0), Color.White);
                        _spriteBatch.Draw(gameoverSprite, new Vector2((screenWidth / 2) - 250, (screenHeight / 2) - 250), Color.White);
                    }
                }
            }           

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
