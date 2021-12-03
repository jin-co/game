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
        private string[] pageMainNames = { };

        public ContentManager Content { get; set; }
        public Texture2D Sprite { get; set; }


        public Page(ContentManager content)
        {
            Content = content;
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

            if (kState.IsKeyDown(Keys.Left))
            {

            }

            if (kState.IsKeyDown(Keys.Right))
            {

            }
        }
    }
}
