using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class PuzzleData
    {
        public static int currentLevel = 1;
        public static PictureBox[,] pieces;
        public static PictureBox[,] wholePiece;
        public static string pixBoxNamePrefix = "pictureBox";
        public static Image[] image4Level1 = {
            Resources.m1,
            Resources.m2,
            Resources.m3,
            Resources.m4,
            Resources.m5,
            Resources.m6,
            Resources.m7,
            Resources.m8,
            Resources.m9
        };
        public static Dictionary<string, Image> imageSet = 
            new Dictionary<string, Image>();
        public static bool notLoaded = true;

        public static void LoadImage()
        {
            if (currentLevel == 1)
            {
                for (int i = 0; i < image4Level1.Length; i++)
                {
                    string key = pixBoxNamePrefix + i;
                }
            }
        }
    }
}
