using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class Game : PuzzleData
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
                temp.Image = toBox.Image;
                temp.Tag = toBox.Tag;
                toBox.Image = fromBox.Image;
                toBox.Tag = fromBox.Tag;
                fromBox.Image = null;
                fromBox.Tag = toBox.Tag;
                puzzleCompleted();
            }
            else
            {
                fromBox = clicked;
            }
        }

        private void puzzleCompleted()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                }
            }
        }
    }
}
