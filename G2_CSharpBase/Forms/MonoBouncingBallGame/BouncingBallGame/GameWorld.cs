using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace BouncingBallGame
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Ball ball;
        private Bat bat;
        private Explosion explosion;
        private CollisionDetection collisionDetection;

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            Vector2 screenDimension = new Vector2(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);

            ball = new Ball();
            ball.ScreenDimension = screenDimension;
            ball.Load(Content);

            bat = new Bat();
            bat.Load(Content);
            bat.ScreenDimension = screenDimension;

            explosion = new Explosion(Content);
            SoundEffect dingSound = Content.Load<SoundEffect>("Music/ding");
            ball.explosion = explosion;

            collisionDetection = new CollisionDetection(ball, bat,dingSound, explosion);

            Song song = Content.Load<Song>("Music/chimes");

            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(song);

            // TODO: use this.Content to load your game content here
        }

        // game loop
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            ball.Update(gameTime);
            bat.Update(gameTime);
            explosion.Update(gameTime);
            collisionDetection.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            ball.Draw(gameTime, spriteBatch);
            bat.Draw(gameTime, spriteBatch);
            explosion.Draw(gameTime, spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
    }
}
