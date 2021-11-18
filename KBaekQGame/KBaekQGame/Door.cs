using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBaekQGame
{
    class Door : Cube
    {
        public static List<Cube> RedDoors { get; set; }
        public static List<Cube> GreenDoors { get; set; }

        public static void SetDoors()
        {
            RedDoors = new List<Cube>();
            GreenDoors = new List<Cube>();
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    if (Game.Cubes[row, col].Image != null)
                    {
                        if (Game.Cubes[row, col].Image.Tag.ToString() == "4")
                        {
                            RedDoors.Add(Game.Cubes[row, col]);
                        }

                        if (Game.Cubes[row, col].Image.Tag.ToString() == "5")
                        {
                            GreenDoors.Add(Game.Cubes[row, col]);
                        }
                    }
                }
            }
        }
    }
}
