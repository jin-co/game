using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame 
{
    public class Game2DGen : PuzzleData
    {
        protected Control parent;

        public Game2DGen (Control parent)
        {
            this.parent = parent;
        }

        // generating unchanged artifects for our puzzle game (puzzle piece and the whole piece
        public void GenWidgets ()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            int width, height;
            DecideWidthHeith(out width, out height);
            int startX, startY;
            DecideStartXStartY(out startX, out startY);

            if (NotLoaded)
            {
                LoadImage();
            }
            int gapX = 2;
            int gapY = 2;

            int n = 0;

            int x = startX;
            int y = startY;
            if ((rows == 1) && (cols == 1))
                WholePiece = new PictureBox[rows, cols];
            else
                Pieces = new PictureBox[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox p = new PictureBox();
                    p.Left = x;
                    p.Top = y;
                    p.Width = width;
                    p.Height = height;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Name = PicBoxNamePrefix + n;
                    // used to remember our move
                    p.Tag = PicBoxNamePrefix + n;
                    if ((rows == 1) && (cols == 1))
                        WholePiece[0, 0] = p;
                    else
                        Pieces[row, col] = p;
                    x += width + gapX;
                    n++;
                }
                x = startY;
                y += height + gapY;
            }
        }

        // dynamic parts
        public void ShowGame ()
        {
            // changed part for puzzle pieces
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string key = Pieces[row, col].Tag.ToString();
                    Pieces[row, col].Click += new EventHandler(OnClick);
                    Pieces[row, col].Image = ImageSet[key];
                    parent.Controls.Add(Pieces[row, col]);
                }
            }

            ShowWholePiece();
        }

        private void OnClick (object sender, EventArgs e)
        {
            // temp hook
        }

        public void show()
        {
            Console.WriteLine("do sth");
        }

        public void dummy ()
        {
            int x = 1;

            if (x==1)
            {
                //do sth
                show();
            } else if (x==2)
            {
                //do sth else
                show();
            }
        }

        public void dummy1()
        {
            int x = 1;

            if (x == 1)
            {
                //do sth
            }
            else if (x == 2)
            {
                //do sth else
            }
            show();
        }

        // method dummy = dummy1

        private void ShowWholePiece ()
        {
            // show the whole picture
            int tempLevel = CurrentLevel;
            CurrentLevel = 0;
            GenWidgets();
            WholePiece[0, 0].Image = WholeImage;
            parent.Controls.Add(WholePiece[0, 0]);
            CurrentLevel = tempLevel;
        }

        public void LoadPuzzleFromFile (string [] lines)
        {
            CurrentLevel = int.Parse(lines[0]);
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            Pieces = null;
            // produce unchanged part
            GenWidgets();
            int lineNo = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string key = lines[lineNo];
                    Pieces[row, col].Image = ImageSet[key];
                    parent.Controls.Add(Pieces[row, col]);
                    lineNo++;
                }
            }

            ShowWholePiece();
        }
    }
}
