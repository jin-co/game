using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    // page class that controls the pages
    class GamePage
    {
        #region Fields
        private string _currentPage;
        private string[] pageMainNames = { 
            "PageMain/main_start", "PageMain/main_help", "PageMain/main_about" };
        private int _pageIdx = 0;
        private double _timer = 1;
        private Texture2D _sprite;
        #endregion

        #region Properties
        public ContentManager Content { get; set; }        
        #endregion

        #region Constructors
        public GamePage()
        {            
            _currentPage = "PageMain/main_start";
        }
        #endregion

        public void Load()
        {
            _sprite = GameSpriteLoader.Load($"Assets/{_currentPage}");            
        }

        public void PageUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();            
            float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            _timer -= elapsedTime;
            if (_timer < 0.8)
            {
                if (kState.IsKeyDown(Keys.Left))
                {
                    GameSounds.Tap.Play();
                    if (_pageIdx > 0)
                    {
                        _pageIdx--;
                    }
                    else
                    {
                        _pageIdx = pageMainNames.Length - 1;
                    }
                    _currentPage = pageMainNames[_pageIdx];                    
                }

                if (kState.IsKeyDown(Keys.Right))
                {
                    GameSounds.Tap.Play();
                    if (_pageIdx < pageMainNames.Length - 1)
                    {
                        _pageIdx++;
                    }
                    else
                    {
                        _pageIdx = 0;
                    }                    
                    _currentPage = pageMainNames[_pageIdx];                    
                }

                if (kState.IsKeyDown(Keys.Enter))
                {
                    GameSounds.Enter.Play();
                    if (_pageIdx == 0)
                    {
                        GameController.GameStart = true;
                        MediaPlayer.Play(GameSounds.BackgroundMusic);
                    }
                    else
                    {
                        _currentPage = pageMainNames[_pageIdx].Split('_')[1];                        
                    }
                }
                _sprite = GameSpriteLoader.Load($"Assets/{_currentPage}");                
                _timer = 1;
            }           
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_sprite, new Vector2(0, 0), Color.White);
        }
    }
}
