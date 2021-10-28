using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    class Game
    {// variables
        #region Fields
        private int gap = 1, blockSize = 45;
        #endregion

        #region Properties
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int XGap { get; set; }
        public int YGap { get; set; }
        public int XStart { get; set; }
        public int YStart { get; set; }
        public int ImageTag { get; set; }
        public PictureBox[,] Cubes { get; set; }
        public Form Parent { get; set; }
        #endregion

        #region Constructors
        public Game() { }

        public Game(Form parent)
        {
            Parent = parent;
        }


        #endregion

        #region Methods        
        public void Test()
        {
            // clear game board
            Parent.spcBoard.Panel2.Controls.Clear();

            // checks input error
            if (!int.TryParse(txtRows.Text, out rows) || !int.TryParse(txtCols.Text, out cols))
            {
                GameMessage.ShowMessage(1, "Please provide numbers for rows and columns");
            }

            // sets array size
            cubes = new PictureBox[rows, cols];

            // sets starting point
            xStart = (spcBoard.Panel2.Width / 2) - ((cols / 2) * (blockSize + gap));
            yStart = (spcBoard.Panel2.Height / 2) - ((rows / 2) * (blockSize + gap));
            xGap = xStart;
            yGap = yStart;

            // generates board
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = blockSize;
                    pic.Height = blockSize;
                    pic.Left = xGap + (pic.Width * col);
                    pic.Top = yGap + (pic.Height * row);
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    cubes[row, col] = pic;
                    spcBoard.Panel2.Controls.Add(pic);
                    pic.Click += Cube_Click;
                    xGap += gap;
                }
                xGap = xStart;
                yGap += gap;
            }
            yGap = yStart;
        }
        #endregion
    }
}
