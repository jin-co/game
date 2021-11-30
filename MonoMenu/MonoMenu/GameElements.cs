using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MonoMenu
{
    class GameElements
    {
        private ContentManager _content;
        private SpriteElements _background;
        private int _noOfBtns = 3;
        private int _noOfFrames = 3;
        private string[] _btnNames = { "aboutbutton", "helpbutton", "menubutton" };
        private string[] _frameNames = { "about", "help", "menu" };
        private SpriteElements[] _frames;
        private Button[] _btns;
        private bool _selected = false;
        private bool _enterKeyPressed = false;
        private SpriteElements _selectedFrame;

        public GameElements(ContentManager content)
        {
            _content = content;
        }

        public void Load()
        {
            _background = new SpriteElements(_content);
            _background.Load("background");
            for (int i = 0; i < _noOfBtns; i++)
            {
                Button btn = new Button();
                
            }
        }

    }
}
