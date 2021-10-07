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
            Resources.m9,
            null,
            null,
            null
        };
        public static Image wholeImage = Resources.whole;
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
                    imageSet.Add(key, image4Level1[i]);
                }
            }
        }

        public static int[,] rowCols4LevelX = {
            {0, 1, 1 },
            {1, 3, 3 },
            {2, 5, 5 }
        };
        public static void DecideRowsCols(out int rows, out int cols)
        {
            rows = rowCols4LevelX[currentLevel, 1];
            cols = rowCols4LevelX[currentLevel, 2];
        }

        public static int[,] StartPosition = {
            { 0, 480, 20 },
            { 1, 20, 20 },
            { 2, 20, 20}
        };
        public static void DecidePosition(out int startX, out int startY)
        {
            startX = rowCols4LevelX[currentLevel, 1];
            startY = rowCols4LevelX[currentLevel, 2];
        }

        public static int[,] widthHeight4LevelX = {
            { 0, 500, 520 },
            { 1, 140, 140 },
            { 2, 100, 100}
        };
        public static void DecideWidthHeight(out int width, out int height)
        {
            width = rowCols4LevelX[currentLevel, 1];
            height = rowCols4LevelX[currentLevel, 2];
        }
    }
}
