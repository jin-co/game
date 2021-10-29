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
        #endregion

        #region Properties
        public static int Rows { get; set; }
        public static int Cols { get; set; }
        public static int XGap { get; set; }
        public static int YGap { get; set; }
        public static int XStart { get; set; }
        public static int YStart { get; set; }
        public static int ImageTag { get; set; }
        public static int BlockSize { get; set; }
        public static int Gap { get; set; }
        public static Image ToolBoxPic { get; set; }
        public static PictureBox[,] Cubes { get; set; }
        public static SplitContainer SpcBoard { get; set; }        
        public static ImageList ImageList { get; set; }
        #endregion

        #region Constructors
        public Game() { }

        public Game(SplitContainer spcBoard, ImageList imageList)
        {
            SpcBoard = spcBoard;            
            ImageList = imageList;            
            BlockSize = blockSize;
            Gap = gap;
        }
        #endregion

        #region Methods     
        

        /// <summary>
        /// Event handler that fills the game board with the
        /// image chosen from the tool box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Cube_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;
            clicked.Image = ToolBoxPic;
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
                ToolBoxPic = null;
                return;
            }
            ToolBoxPic = ImageList.Images[btn.ImageIndex];
            ImageTag = btn.ImageIndex;
        }       
        #endregion
    }
}
