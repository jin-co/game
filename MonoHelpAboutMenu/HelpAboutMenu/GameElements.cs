using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpAboutMenu
{
    class GameElements
    {
        private ContentManager Content;
        private SpriteElement background;
        private int NoOfButtons = 3;
        private int NoOfFrames = 3;
        private string[] buttonNames = { "aboutbutton", "helpbutton", "menubutton" };
        private string[] frameNames = { "about", "help", "menu" };
        private SpriteElement[] frames;
        private Button[] buttons;
        private bool selected = false;
        private bool enterKeyPressed = false;
        private SpriteElement currentSelectedFrame;

        public GameElements (ContentManager content)
        {
            Content = content;
        }

        public void Load ()
        {
            background = new SpriteElement(Content);
            background.Load("background");

            buttons = new Button[NoOfButtons];
            int x = 394;
            int y = 760;
            int widthChange = 362;
            for (int n = 0; n < NoOfButtons; n++)
            {
                Button button = new Button(Content);
                button.Load(buttonNames[n]);
                button.Position = new Vector2(x, y);
                x += widthChange;
                buttons[n] = button;
            }

            frames = new SpriteElement[NoOfFrames];
            for (int n = 0; n < NoOfFrames; n++)
            {
                SpriteElement frame = new SpriteElement(Content);
                frame.Load(frameNames[n]);
                frame.Position = new Vector2(192, 90);
                frames[n] = frame;
            }
        }

        // game loop
        public void Update (GameTime gameTime)
        {
            for (int n = 0; n < NoOfButtons; n++)
            {
                buttons[n].Reset();
                buttons[n].Update();
                if (buttons[n].pressed)
                {
                    selected = true;
                    currentSelectedFrame = frames[n];
                    break;
                }
            }
            if (Keyboard.GetState().IsKeyDown (Keys.Enter))
            {
                enterKeyPressed = true;
            }
        }

        public void Draw (GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            background.Draw(gameTime, spriteBatch);
            if (selected)
            {
                currentSelectedFrame.Draw(gameTime, spriteBatch);
            } else
            {
                DrawButtons(gameTime, spriteBatch);
            }

            if (enterKeyPressed)
            {
                DrawButtons(gameTime, spriteBatch);
                enterKeyPressed = false;
                selected = false;
            }
            spriteBatch.End();
        }

        private void DrawButtons(GameTime gameTime, SpriteBatch spriteBatch)
        {
            for (int n = 0; n < NoOfButtons; n++)
            {
                buttons[n].Draw(gameTime, spriteBatch);
            }
        }
    }
}
