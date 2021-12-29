using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Game class that has properties to be used 
     * across the classes
     * when it is called it sets the basic settings 
     * such as gap and cube size
     */
    class Game
    {// variables
        #region Fields
        private int gap = 1, cubeSize = 45;
        #endregion

        #region Properties
        public static int Rows { get; set; }
        public static int Cols { get; set; }
        public static int XGap { get; set; }
        public static int YGap { get; set; }
        public static int XStart { get; set; }
        public static int YStart { get; set; }        
        public static int CubeSize { get; set; }
        public static int Gap { get; set; }        
        public static bool IsPlay { get; set; }
        public static bool IsMove { get; set; } 
        public static Cube[,] Cubes { get; set; }
        public static SplitContainer SpcBoard { get; set; }        
        public static ImageList ImageList { get; set; }
        public static TextBox BoxesLeftDisplay { get; set; } 
        public static TextBox MovementDisplay { get; set; }
        public static string LoadString { get; set; }
        public static List<Button> Cursors { get; set; }
        #endregion

        #region Constructors
        public Game() { }

        public Game(SplitContainer spcBoard, ImageList imageList)
        {
            SpcBoard = spcBoard;            
            ImageList = imageList;            
            CubeSize = cubeSize;
            Gap = gap;
            IsPlay = false;
            IsMove = false;
        }
        #endregion       
    }
}
