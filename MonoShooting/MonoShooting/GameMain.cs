using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
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
        Texture2D ground;
        Texture2D bullet;
        Texture2D collisionEffectSprite;        
               
        Biker biker;
        Page page;
        Ladder ladder;
        Box box;
        //test
        Texture2D dog;
        
        GameController controller = new GameController();
        GameStage stage = new GameStage();

        Vector2 collisionPoint;

        //timer
        SpriteFont timerFont;

        //test
        Vector2 testBikerP;
        Vector2 testLaddetP;
        bool testCollide = false;
        bool testContact = false;
        //test

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
            ladder = new Ladder(Content);
            box = new Box(Content);
            //dog = new Dog(Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            ground = Content.Load<Texture2D>("Assets/ground");
            bullet = Content.Load<Texture2D>("Assets/Enemies/bullet");            
            collisionEffectSprite = Content.Load<Texture2D>("Assets/effect_collision");            
            gameoverBackSprite = Content.Load<Texture2D>("Assets/gameover_back");
            gameoverSprite = Content.Load<Texture2D>("Assets/gameover");
            timerFont = Content.Load<SpriteFont>("Assets/timerFont");
            biker.BikerLoad();
            page.Load();
            ladder.Load();
            box.Load();
            //dog.Load();
            dog = Content.Load<Texture2D>("Assets/Enemies/Dog/Idle");
            Dog.Content = Content;

            Sounds.BackgroundMusic = Content.Load<Song>("Assets/Sounds/sound_back");
            Sounds.BackgroundMusicEnd = Content.Load<Song>("Assets/Sounds/sound_back_end");
            Sounds.BackgroundMusicInbound = Content.Load<Song>("Assets/Sounds/sound_back_inbound");
            Sounds.BackgroundMusicSlayer = Content.Load<Song>("Assets/Sounds/sound_back_slayer");
            Sounds.StageClear = Content.Load<SoundEffect>("Assets/Sounds/sound_clear");
            Sounds.Dead = Content.Load<SoundEffect>("Assets/Sounds/sound_dead");
            Sounds.Hurt = Content.Load<SoundEffect>("Assets/Sounds/sound_hurt_man");
            Sounds.Bullet = Content.Load<SoundEffect>("Assets/Sounds/sound_bullet");
            Sounds.DogBark = Content.Load<SoundEffect>("Assets/Sounds/sound_dog_bark");
            MediaPlayer.Play(Sounds.BackgroundMusicEnd);

            //game level
            GameController.GameLevel = 1;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (!GameController.GameStart)
            {
                page.PageUpdate(gameTime);                
            }
            else
            {
                
                if (!GameController.GameClear)
                {
                    if (!GameController.GameOver)
                    {
                        switch (GameController.GameLevel)
                        {
                            case 1:
                                biker.BikerUpdate(gameTime);
                                controller.Update(gameTime);

                                foreach (var i in controller.Bullets)
                                {
                                    i.BulletUpdate(gameTime);
                                    if (Vector2.Distance(i.position, biker.Position)
                                        >= i.radius + biker.Radius &&
                                        Vector2.Distance(i.position, biker.Position)
                                        < (i.radius + biker.Radius) + 5)
                                    {
                                        Sounds.Bullet.Play();
                                    }

                                    if (Vector2.Distance(i.position, biker.Position)
                                        < i.radius + biker.Radius)
                                    {
                                        biker.Dead = true;
                                        Sounds.Hurt.Play();
                                        biker.BikerUpdate(gameTime);
                                        collisionPoint = new Vector2(
                                            i.position.X - i.radius, i.position.Y - i.radius);
                                    }
                                }
                                if (Vector2.Distance(ladder.Position, biker.Position)
                                    <= ladder.Radius + biker.Radius)
                                {
                                    MediaPlayer.Stop();
                                    Sounds.StageClear.Play();
                                    GameController.GameClear = true;
                                }
                                break;

                            case 2:
                                if (Vector2.Distance(ladder.Position, biker.Position)
                                    <= ladder.Radius + biker.Radius &&
                                    !biker.OnSecondStage)
                                {
                                    GameController.Climbable = true;
                                    testContact = true;
                                    testCollide = true;
                                }
                                else
                                {
                                    testContact = false;
                                    GameController.Climbable = false;
                                }
                                biker.BikerUpdate(gameTime);
                                controller.Update(gameTime);

                                if (biker.OnSecondStage)
                                {
                                    controller.Update(gameTime);
                                    foreach (var i in controller.Dogs)
                                    {
                                        i.Update(gameTime, biker.Position);

                                        if (Vector2.Distance(i.position, biker.Position)
                                            >= i.radius + biker.Radius &&
                                            Vector2.Distance(i.position, biker.Position)
                                            < (i.radius + biker.Radius) + 5)
                                        {
                                            Sounds.DogBark.Play();
                                        }

                                        if (Vector2.Distance(i.position, biker.Position)
                                            < i.radius + biker.Radius - 10)
                                        {
                                            biker.Dead = true;
                                            Sounds.Hurt.Play();
                                            Sounds.DogBark.Dispose();
                                            biker.BikerUpdate(gameTime);
                                            collisionPoint = new Vector2(
                                                i.position.X - i.radius, i.position.Y - i.radius);
                                        }
                                    }

                                    // stage 2 clear
                                    if (Vector2.Distance(box.Position, biker.Position)
                                    <= box.Radius + biker.Radius)
                                    {
                                        MediaPlayer.Stop();
                                        Sounds.StageClear.Play();
                                        GameController.GameClear = true;
                                    }
                                }
                                break;
                        }                        
                    }
                    else
                    {
                        biker.BikerUpdate(gameTime);
                    }
                }
                else
                {
                    stage.Update(gameTime, biker);
                }
                
            }        
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            // main page
            if (!GameController.GameStart)
            {
                page.Draw(gameTime, _spriteBatch);
            }

            //game play
            if (GameController.GameStart)
            {
                _spriteBatch.Draw(ground, new Vector2(0, 0), Color.White);
                
                // timer
                _spriteBatch.DrawString(timerFont,
                "Time: " + Math.Floor(GameController.TotalTime),
                new Vector2(3, 3), Color.Black);

                // ladder
                ladder.Draw(gameTime, _spriteBatch);

                // plaer
                biker.Draw(gameTime, _spriteBatch);
                foreach (var i in controller.Bullets)
                {
                    _spriteBatch.Draw(bullet, new Vector2(i.position.X, i.position.Y + i.radius), Color.White);
                }

                // game clear
                if (GameController.GameClear)
                {
                    _spriteBatch.DrawString(
                    timerFont,
                    "Stage" + GameController.GameLevel + " Cleared",
                    new Vector2((screenWidth / 2) - 85, (screenHeight / 2) - 40), Color.Black);
                }

                if (GameController.GameLevel == 2)
                {
                    box.Draw(gameTime, _spriteBatch);
                    foreach (var i in controller.Dogs)
                    {
                        Dog.Draw(gameTime, _spriteBatch, i.position);
                        //_spriteBatch.Draw(
                        //    dog, 
                        //    new Vector2(i.position.X, i.position.Y + i.radius),
                        //    new Rectangle(0, 0, 48, 48),
                        //    Color.White);
                    }                    
                }

                // game over
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

            //test
            _spriteBatch.DrawString(
                    timerFont,
                    testBikerP.ToString() + "\n" +
                    testLaddetP.ToString() + "\n" +
                    testCollide.ToString() + "\n" +
                    testContact.ToString() + "\n" +
                    "Climbable: " + GameController.Climbable.ToString() + "\n" +
                    "biker: " + biker.Position.ToString() + "\n" +
                    "ladder: " + ladder.Position.ToString() + "\n" 
                    ,
                    new Vector2(100, 100), Color.Black);
            
            //test

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
