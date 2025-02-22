﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace MonoShooting
{
    /* Author: Kwangjin Baek
     * Date: 2021. Dec. 1.
     * Description: game that a player has to get to
     * the finish point to win
     */
    public class GameMain : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        int screenWidth = 1400;
        int screenHeight = 950;

        Biker biker = new Biker();
        GamePage page = new GamePage();
        Ladder ladder = new Ladder();
        Box box = new Box();
        
        GameController controller = new GameController();
        GameStage stage = new GameStage();

        Vector2 collisionPoint;

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
            GameSounds sound = new GameSounds(Content);
            GameSpriteLoader.Content = Content;
            GameSpriteFontLoader.Content = Content;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            biker.BikerLoad();
            page.Load();
            ladder.Load();
            box.Load();                                   
            MediaPlayer.Play(GameSounds.BackgroundMusicEnd);                        
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            GamePause.Update(gameTime);

            if (!GameController.Pause)
            {
                MediaPlayer.Resume();
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
                                            >= i.Radius + biker.Radius &&
                                            Vector2.Distance(i.position, biker.Position)
                                            < (i.Radius + biker.Radius) + 5)
                                        {
                                            GameSounds.Bullet.Play();
                                        }

                                        if (Vector2.Distance(i.position, biker.Position)
                                            < i.Radius + biker.Radius)
                                        {
                                            biker.Dead = true;
                                            GameSounds.Hurt.Play();
                                            biker.BikerUpdate(gameTime);
                                            collisionPoint = new Vector2(
                                                i.position.X - i.Radius, i.position.Y - i.Radius);
                                        }
                                    }
                                    if (Vector2.Distance(ladder.Position, biker.Position)
                                        <= ladder.Radius + biker.Radius)
                                    {
                                        MediaPlayer.Stop();
                                        GameSounds.StageClear.Play();
                                        GameController.GameClear = true;
                                    }
                                    break;

                                case 2:
                                    if (Vector2.Distance(ladder.Position, biker.Position)
                                        <= ladder.Radius + biker.Radius &&
                                        !biker.OnSecondStage)
                                    {
                                        GameController.Climbable = true;
                                    }
                                    else
                                    {
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
                                                >= i.Radius + biker.Radius &&
                                                Vector2.Distance(i.position, biker.Position)
                                                < (i.Radius + biker.Radius) + 5)
                                            {
                                                GameSounds.DogBark.Play();
                                            }

                                            if (Vector2.Distance(i.position, biker.Position)
                                                < i.Radius + biker.Radius - 10)
                                            {
                                                biker.Dead = true;
                                                GameSounds.Hurt.Play();                                                
                                                biker.BikerUpdate(gameTime);
                                                collisionPoint = new Vector2(
                                                    i.position.X - i.Radius,
                                                    i.position.Y - i.Radius);
                                            }
                                        }

                                        // stage 2 clear
                                        if (Vector2.Distance(box.Position, biker.Position)
                                        <= box.Radius + biker.Radius)
                                        {
                                            MediaPlayer.Stop();
                                            GameSounds.StageClear.Play();
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
            }
            else
            {
                MediaPlayer.Pause();
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
                _spriteBatch.Draw(
                    GameSpriteLoader.Load("Assets/ground"), 
                    new Vector2(0, 0), Color.White);
                
                // timer
                _spriteBatch.DrawString(
                    GameSpriteFontLoader.Load("Assets/timerFont"),
                    "Time: " + Math.Floor(GameController.TotalTime),
                    new Vector2(3, 3), Color.Black);

                // ladder
                ladder.Draw(gameTime, _spriteBatch);

                // bullet
                biker.Draw(gameTime, _spriteBatch);
                foreach (var i in controller.Bullets)
                {
                    _spriteBatch.Draw(
                        GameSpriteLoader.Load("Assets/Enemies/bullet"), 
                        new Vector2(i.position.X, i.position.Y + i.Radius), 
                        Color.White);
                }

                // game clear
                if (GameController.GameClear)
                {
                    _spriteBatch.DrawString(
                    GameSpriteFontLoader.Load("Assets/timerFont"),
                    "Stage" + GameController.GameLevel + " Cleared",
                    new Vector2((screenWidth / 2) - 85, 
                    (screenHeight / 2) - 40), Color.Black);
                }

                if (GameController.GameLevel == 2)
                {
                    box.Draw(gameTime, _spriteBatch);
                    foreach (var i in controller.Dogs)
                    {
                        Dog.Draw(gameTime, _spriteBatch, i.position);
                    }                    
                }

                // game over
                if (GameController.GameOver)
                {
                    _spriteBatch.Draw(
                        GameSpriteLoader.Load("Assets/effect_collision"), 
                        collisionPoint, Color.White);

                    timer -= gameTime.ElapsedGameTime.TotalSeconds;
                    if (timer <= 0.5)
                    {
                        _spriteBatch.Draw(
                            GameSpriteLoader.Load("Assets/gameover_back"), 
                            new Vector2(0, 0), Color.White);
                        _spriteBatch.Draw(
                            GameSpriteLoader.Load("Assets/gameover"), 
                            new Vector2((screenWidth / 2) - 250, (screenHeight / 2) - 250), 
                            Color.White);
                    }
                }
            }            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
