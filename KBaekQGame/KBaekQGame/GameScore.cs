using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBaekQGame
{
    class GameScore
    {
        public static int BoxCount { get; set; }
        public static int MovementCount { get; set; }

        public static void UpdateBoxCount()
        {
            BoxCount = 0;
            
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    if (Game.Cubes[row, col].Image != null)
                    {
                        if (Game.Cubes[row, col].Image.Tag.ToString() == "4")
                        {
                            BoxCount++;
                        }

                        if (Game.Cubes[row, col].Image.Tag.ToString() == "5")
                        {
                            BoxCount++;
                        }
                    }
                }
            }
        }
    }
}
