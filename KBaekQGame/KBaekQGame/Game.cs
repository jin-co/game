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
        public static int BlockSize { get; set; }
        public static int Gap { get; set; }        
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
    }
}
