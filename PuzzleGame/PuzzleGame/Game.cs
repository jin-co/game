using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class Game
    {
        private PictureBox fromBox;
        private PictureBox toBox;
        public void OnClick (object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;
            if (fromBox == null)
            {
                if (clicked.Image != null)
                {
                    fromBox = clicked;
                }
                else
                {
                    return;
                }
            }
            else if (clicked.Image == null)
            {
                toBox = clicked;
                PictureBox temp = new PictureBox();
            }
        }
    }
}
