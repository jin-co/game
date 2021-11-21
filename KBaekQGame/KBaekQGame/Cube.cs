using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    // Sub class PictureBox that stores the data for boxes
    // and adds necessary features for a box
    class Cube : PictureBox
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static List<Cube> RedCubes { get; set; }
        public static List<Cube> GreenCubes { get; set; }

        /// <summary>
        /// Generates lists of red and green boxes with tags attached
        /// and add count of each box
        /// </summary>
        public static void SetCubes()
        {
            RedCubes = new List<Cube>();
            GreenCubes = new List<Cube>();
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    if (Game.Cubes[row, col] != null && 
                        Game.Cubes[row, col].Image != null)
                    {
                        if (Game.Cubes[row, col].Image.Tag.ToString() == "4")
                        {
                            RedCubes.Add(Game.Cubes[row, col]);
                            GameScore.BoxCount++;
                        }

                        if (Game.Cubes[row, col].Image.Tag.ToString() == "5")
                        {
                            GreenCubes.Add(Game.Cubes[row, col]);
                            GameScore.BoxCount++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// When Detection happens between boxes
        /// prevent passing through when they are different
        /// merges when they are the same
        /// </summary>
        /// <param name="cube"></param>
        /// <returns></returns>
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
                        i.Image = null;
                        Game.SpcBoard.Panel2.Controls.Remove(i);
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
                        i.Image = null;
                        Game.SpcBoard.Panel2.Controls.Remove(i);
                    }
                }
            }
            return false;
        }
    }
}
