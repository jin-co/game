using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class Game2DGen : PuzzleData
    {
        protected Control parent;
        public Game2DGen(Control parent)
        {
            this.parent = parent;
        }

        public void GenWidget()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);

            int width, height;
            DecideWidthHeight(out width, out height);

            int startX, startY;
            DecidePosition(out startX, out startY);

            if (notLoaded)
            {
                LoadImage();
            }

            int gapX = 2;
            int gapY = 2;
            int n = 0;

            int x = startX;
            int y = startY;

            if (rows == 1 && cols == 1)
            {
                wholePiece = new PictureBox[rows, cols];
            }
            else
            {
                pieces = new PictureBox[rows, cols];
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Left = x;
                    pic.Top = y;
                    pic.Width = width;
                    pic.Height = height;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Name = pixBoxNamePrefix + n;
                    pic.Tag = pic.Name;
                    if (rows == 1 && cols == 1)
                    {
                        wholePiece[0, 0] = pic;
                    }
                    else
                    {
                        pieces[row, col] = pic;
                    }
                }

                x += width + gapX;
                n++;
            }

            x = startY;
            y += height + gapY;
        }

        public void ShowGame()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string key = pieces[row, col].Tag.ToString();
                    pieces[row, col].Click += new EventHandler(new Game().OnClick);
                    pieces[row, col].Image = imageSet[key];
                    parent.Controls.Add(pieces[row, col]);
                }
            }

            int tempLevel = currentLevel;
            currentLevel = 0;
            GenWidget();
            wholePiece[0, 0].Image = wholeImage;
            parent.Controls.Add(wholePiece[0, 0]);
        }

        public void LoadPuzzleFromFile(string[] lines)
        {
            currentLevel = int.Parse(lines[0]);
            int rows, cols;
            DecideRowsCols(out cols, out rows);
            pieces = null;
            GenWidget();

        }
    }
}
