using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public class PuzzleData
    {
        public static int CurrentLevel = 1;
        // game 2D data
        public static PictureBox[,] Pieces;
        public static PictureBox[,] WholePiece;
        public static string PicBoxNamePrefix = "pictureBox";
        // Game image
        public static Image [] Image4Level1 = {Resource1.m1, Resource1.m2, Resource1.m3,
                                               Resource1.m4, Resource1.m5, Resource1.m6,
                                               Resource1.m7, Resource1.m8, Resource1.m9,
                                               null, null, null
        };
        public static Dictionary<string, Image> ImageSet = new Dictionary<string, Image>();
        public static bool NotLoaded = true;

        public static void LoadImage ()
        {
            if (CurrentLevel == 1)
            {
                for (int n = 0; n < Image4Level1.Length; n++)
                {
                    string key = PicBoxNamePrefix + n;
                    ImageSet.Add(key, Image4Level1[n]);
                }
            }
        }

        // Game Level Dynamic - Change this part to have only 2 elements in the second dimension
        // For example: RowCols4LevelX = { { 0, 1, 1}, { 1, 4, 3}, { 2, 6, 5 } };
        // RowCols4LevelX = { { 1, 1}, { 4, 3}, { 6, 5 } };
        public static int[,] RowCols4LevelX = { { 0, 1, 1}, { 1, 4, 3}, { 2, 6, 5 } };
        public static void DecideRowsCols (out int rows, out int cols)
        {
            rows = RowCols4LevelX[CurrentLevel, 1];
            cols = RowCols4LevelX[CurrentLevel, 2];
        }
        public static int[,] StartPosition4LevelX = { {0, 480, 20 }, {1, 20, 20 }, {2, 20, 20} };
        public static void DecideStartXStartY(out int startX, out int startY)
        {
            startX = StartPosition4LevelX[CurrentLevel, 1];
            startY = StartPosition4LevelX[CurrentLevel, 2];
        }
        public static int[,] WidthHeigh4LevelX = { {0, 520,520},{1, 140, 140 },{2, 100, 100} };
        public static void DecideWidthHeith(out int width, out int height)
        {
            width = WidthHeigh4LevelX[CurrentLevel, 1];
            height = WidthHeigh4LevelX[CurrentLevel, 2];
        }

    }
}
