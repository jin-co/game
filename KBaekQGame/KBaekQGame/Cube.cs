using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    class Cube : PictureBox
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static List<Cube> RedCubes { get; set; }
        public static List<Cube> GreenCubes { get; set; }

        public static void SetCubes()
        {
            RedCubes = new List<Cube>();
            GreenCubes = new List<Cube>();
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    if (Game.Cubes[row, col].Image != null)
                    {
                        if (Game.Cubes[row, col].Image.Tag.ToString() == "4")
                        {
                            RedCubes.Add(Game.Cubes[row, col]);
                            GameScore.UpdateBoxCount();
                        }

                        if (Game.Cubes[row, col].Image.Tag.ToString() == "5")
                        {
                            GreenCubes.Add(Game.Cubes[row, col]);
                            GameScore.UpdateBoxCount();
                        }
                    }
                }
            }
        }

        public static bool DetectCollision(Cube cube)
        {
            if (RedCubes.Contains(cube))
            {
                foreach (var i in GreenCubes)
                {
                    if (i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (var i in GreenCubes)
                {
                    if (i != cube && i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        Game.SpcBoard.Panel2.Controls.Remove(i);
                        SetCubes();
                    }
                }
            }

            if (GreenCubes.Contains(cube))
            {
                foreach (var i in RedCubes)
                {
                    if (i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (var i in RedCubes)
                {
                    if (i != cube && i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        Game.SpcBoard.Panel2.Controls.Remove(i);
                        SetCubes();
                    }
                }
            }

            return false;
        }
    }
}
