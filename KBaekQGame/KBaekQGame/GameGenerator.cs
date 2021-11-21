using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Game Generator class that creates game board
     * based on the rows and cols entered
     */
    class GameGenerator
    {
        /// <summary>
        /// Generates game board using picture boxes dynamically 
        /// based on the rows and columns that a user has entered
        /// </summary>
        public static void GenerateGame()
        {
            // clear game board
            Game.SpcBoard.Panel2.Controls.Clear();

            // sets starting point
            Game.XStart = 
                (Game.SpcBoard.Panel2.Width / 2) - 
                ((Game.Cols / 2) * (Game.CubeSize + Game.Gap));
            Game.YStart = 
                (Game.SpcBoard.Panel2.Height / 2) - 
                ((Game.Rows / 2) * (Game.CubeSize + Game.Gap));
            Game.XGap = Game.XStart;
            Game.YGap = Game.YStart;

            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    Cube cube = new Cube();
                    cube.Width = Game.CubeSize;
                    cube.Height = Game.CubeSize;
                    cube.Left = Game.XGap + (cube.Width * col);
                    cube.Top = Game.YGap + (cube.Height * row);                    
                    cube.SizeMode = PictureBoxSizeMode.StretchImage;
                    cube.BorderStyle = BorderStyle.Fixed3D;

                    cube.X = row;
                    cube.Y = col;

                    // differentiates behavior of cube click event between
                    // when play and design
                    if (!Game.IsPlay)
                    {                        
                        cube.Click += EventCatcher.Cube_Click;
                    }
                    else
                    {
                        cube.Click += EventCatcher.PlayCursor_Click;
                    }
                    Game.Cubes[row, col] = cube;
                    Game.SpcBoard.Panel2.Controls.Add(cube);
                    Game.XGap += Game.Gap;
                }
                Game.XGap = Game.XStart;
                Game.YGap += Game.Gap;
            }
            Game.YGap = Game.YStart;

            if (Game.IsPlay)
            {
                AddPictures();
            }
        }

        /// <summary>
        /// Adds pictures to created boxes
        /// </summary>
        private static void AddPictures()
        {
            if (Game.LoadString != null)
            {
                for (int i = 2, j = 3, k = 4; k < Game.LoadString.Length; i += 3, j += 3, k += 3)
                {
                    if (int.Parse(Game.LoadString[k].ToString()) != 0)
                    {
                        string tag = Game.LoadString[k].ToString();
                        Game.Cubes[int.Parse(Game.LoadString[i].ToString()),
                            int.Parse(Game.LoadString[j].ToString())].Image =
                            Game.ImageList.Images[int.Parse(Game.LoadString[k].ToString())];
                        Game.Cubes[int.Parse(Game.LoadString[i].ToString()),
                            int.Parse(Game.LoadString[j].ToString())].Image.Tag =
                            int.Parse(Game.LoadString[k].ToString());
                    }
                }

                RemoveEmptyBoxes();

                // Adds created walls to a list for collision test
                Wall.SetWalls();

                // Adds created boxes to each set of a list for collision test
                Cube.SetCubes();

                // Adds created doors to each set of a list for collision test
                Door.SetDoors();
            }            
        }

        /// <summary>
        /// Removes empty boxes after creating game board
        /// leaving only boxed(red and green) on the board
        /// </summary>
        public static void RemoveEmptyBoxes()
        {
            //test clean -> delete box without pic
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    if (Game.Cubes[row, col].Image == null)
                    {
                        Game.Cubes[row, col] = null;
                        Game.SpcBoard.Panel2.Controls.Remove(Game.Cubes[row, col]);
                    }
                }
            }
        }
    }
}
