using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzle
{
    class PuzzleData
    {
        public static int CurrentLevel = 1;

        public static PictureBox[,] Pieces;
        public static PictureBox[,] WholePiece;
        public static string PicBoxNamePrefix = "pictureBox";

        public static Image[] Image4Level1 =
        {
            Resources.m1,
            Resources.m2,
            Resources.m3,
            Resources.m4,
            Resources.m5,
            Resources.m6,
            Resources.m7,
            Resources.m8,
            Resources.m9,
            null,
            null,
            null
        };

        public static Image WholeImage = Resources.whole;

        public static Dictionary<string, Image> ImageSet = new Dictionary<string, Image>();
        public static bool NotLoaded = true;

        public static void LoadImage()
        {
            if (CurrentLevel == 1)
            {
                for (int i = 0; i < Image4Level1.Length; i++)
                {
                    string key = PicBoxNamePrefix + i;
                    ImageSet.Add(key, Image4Level1[i]);
                }
            }
        }

        public static int[,] RowCols4LevelX =
        {
            {0, 1, 1},
            {1, 4, 3},
            {2, 6, 5},
        };

        public static void DecideRowsCols(out int rows, out int cols)
        {
            rows = RowCols4LevelX[CurrentLevel, 1];
            cols = RowCols4LevelX[CurrentLevel, 2];
        }

        public static int[,] StarPosition4LevelX =
        {
            {0, 480, 20},
            {0, 20, 20},
            {0, 20, 20}
        };

        public static void DecideStartXStartY(out int startX, out int startY)
        {
            startX = StarPosition4LevelX[CurrentLevel, 1];
            startY = StarPosition4LevelX[CurrentLevel, 2];
        }

        public static int[,] WidthHeight4LevelX =
        {
            {0, 520, 520},
            {1, 140, 140},
            {2, 100, 100},
        };
        public static void DecideWidthHeight(out int width, out int height)
        {
            width = WidthHeight4LevelX[CurrentLevel, 1];
            height = WidthHeight4LevelX[CurrentLevel, 2];
        }
    }
}
