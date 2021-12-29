using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzle
{
    class GameEventHandler : PuzzleData
    {
        private PictureBox fromBox;
        private PictureBox toBox;

        public void MouseDown(object sender, EventArgs eventArgs)
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
            else
            {
                if (clicked.Image == null)
                {
                    toBox = clicked;
                    PictureBox temp = new PictureBox();
                    temp.Image = toBox.Image;
                    temp.Tag = toBox.Tag;
                    toBox.Image = fromBox.Image;
                    toBox.Tag = fromBox.Tag;
                    fromBox.Image = null;
                    fromBox.Tag = temp.Tag;
                }
                else
                {
                    fromBox = clicked;
                    return;
                }
            }
            PuzzleCompleted();
        }

        private void PuzzleCompleted()
        {
            int rows = 3;
            int cols = 3;
            int n = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string key = PicBoxNamePrefix + n;
                    n++;
                    Image image = ImageSet[key];
                    if (Pieces[row, col].Image != image)
                    {
                        return;
                    }

                }
            }
            MessageBox.Show("Completed");
        }

        public void Scramble()
        {
            int[] scramble = { 1, 3, 5, 2, 4, 6, 7, 0, 8 };
            int rows = 3;
            int cols = 3;
            int n = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string key = PicBoxNamePrefix + scramble[n];
                    Pieces[row, col].Image = ImageSet[key];
                    n++;
                }
            }
        }
    }
}
