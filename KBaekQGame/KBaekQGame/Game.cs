using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Image toolBoxPic;
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
        public SplitContainer SpcBoard { get; set; }        
        public ImageList ImageList { get; set; }
        #endregion

        #region Constructors
        public Game() { }

        public Game(SplitContainer spcBoard, ImageList imageList)
        {
            SpcBoard = spcBoard;            
            ImageList = imageList;
        }
        #endregion

        #region Methods        
        public void GenerateGame()
        {
            // clear game board
            SpcBoard.Panel2.Controls.Clear();

            // sets array size
            Cubes = new PictureBox[Rows, Cols];

            // sets starting point
            XStart = (SpcBoard.Panel2.Width / 2) - ((Cols / 2) * (blockSize + gap));
            YStart = (SpcBoard.Panel2.Height / 2) - ((Rows / 2) * (blockSize + gap));
            XGap = XStart;
            YGap = YStart;

            // generates board
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = blockSize;
                    pic.Height = blockSize;
                    pic.Left = XGap + (pic.Width * col);
                    pic.Top = YGap + (pic.Height * row);
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    Cubes[row, col] = pic;
                    SpcBoard.Panel2.Controls.Add(pic);
                    pic.Click += Cube_Click;
                    XGap += gap;
                }
                XGap = XStart;
                YGap += gap;
            }
            YGap = YStart;
        }

        /// <summary>
        /// Event handler that fills the game board with the
        /// image chosen from the tool box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cube_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;
            clicked.Image = toolBoxPic;
            clicked.Tag = ImageTag;
        }

        /// <summary>
        /// Event handler that selects a image from the tool box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ToolBox_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ImageIndex == 0)
            {
                toolBoxPic = null;
                return;
            }
            toolBoxPic = ImageList.Images[btn.ImageIndex];
            ImageTag = btn.ImageIndex;
        }       
        #endregion
    }
}
