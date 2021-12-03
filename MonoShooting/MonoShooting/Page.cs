using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoShooting
{
    class Page
    {
        private string _currentPage;
        private string[] pageMainNames = {"start", "help", "about"};
        private int _pageIdx = 0;
        private double _timer = 1;
        

        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }


        public Page(ContentManager content)
        {
            Content = content;
            _currentPage = "start";
        }

        public Texture2D Load()
        {
            Sprite = Content.Load<Texture2D>($"Assets/PageMain/main_{_currentPage}");
            return Sprite;
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
                    if (_pageIdx > 0)
                    {
                        _pageIdx--;
                    }
                    else
                    {
                        _pageIdx = pageMainNames.Length - 1;
                    }
                    _currentPage = pageMainNames[_pageIdx];
                    Sprite = Content.Load<Texture2D>($"Assets/PageMain/main_{_currentPage}");
                }

                if (kState.IsKeyDown(Keys.Right))
                {
                    if (_pageIdx < pageMainNames.Length - 1)
                    {
                        _pageIdx++;
                    }
                    else
                    {
                        _pageIdx = 0;
                    }                    
                    _currentPage = pageMainNames[_pageIdx];
                    Sprite = Content.Load<Texture2D>($"Assets/PageMain/main_{_currentPage}");
                }
                _timer = 1;
            }           
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, new Vector2(0, 0), Color.White);
        }
    }
}
