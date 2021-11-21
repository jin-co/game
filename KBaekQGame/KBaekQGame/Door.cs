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
                    if (Game.Cubes[row, col] != null && Game.Cubes[row, col].Image != null)
                    {
                        if (Game.Cubes[row, col].Image.Tag.ToString() == "2")
                        {
                            RedDoors.Add(Game.Cubes[row, col]);
                        }

                        if (Game.Cubes[row, col].Image.Tag.ToString() == "3")
                        {
                            GreenDoors.Add(Game.Cubes[row, col]);
                        }
                    }
                }
            }
        }

        public static void DetectDoorCollision(Cube cube)
        {
            if (RedCubes.Contains(cube))
            {
                foreach (var i in RedDoors)
                {
                    if (i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        cube.Image = null;
                        Game.SpcBoard.Panel2.Controls.Remove(cube);
                        EventCatcher.CubeTimer.Stop();
                        GameScore.BoxCount--;
                    }
                }
            }

            if (GreenCubes.Contains(cube))
            {
                foreach (var i in GreenDoors)
                {
                    if (i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        cube.Image = null;
                        Game.SpcBoard.Panel2.Controls.Remove(cube);
                        EventCatcher.CubeTimer.Stop();
                        GameScore.BoxCount--;
                    }
                }                
            }
        }
    }
}
