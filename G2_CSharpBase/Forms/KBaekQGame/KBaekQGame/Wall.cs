﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    class Wall : Cube
    {
        #region Properties
        public static List<Cube> Walls { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Creates wall list to detect collision with boxes
        /// </summary>
        public static void SetWalls()
        {
            Walls = new List<Cube>();
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    if (Game.Cubes[row, col] != null && Game.Cubes[row, col].Image != null)
                    {
                        if (Game.Cubes[row, col].Image.Tag.ToString() == "1")
                        {
                            Walls.Add(Game.Cubes[row, col]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Detects collision between boxes        
        /// </summary>
        /// <param name="cube"></param>
        /// <returns></returns>
        public static bool DetectWallCollision(Cube cube)
        {
            foreach (var i in Walls)
            {
                if (i.Bounds.IntersectsWith(cube.Bounds))
                {
                    return true;
                }
            }

            if (GreenCubes.Contains(cube))
            {
                foreach (var i in Door.RedDoors)
                {
                    if (i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        return true;
                    }
                }
            }

            if (RedCubes.Contains(cube))
            {
                foreach (var i in Door.GreenDoors)
                {
                    if (i.Bounds.IntersectsWith(cube.Bounds))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion
    }
}

