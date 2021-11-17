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

            // generates board
            //for (int row = 0; row < Game.Rows; row++)
            //{
            //    for (int col = 0; col < Game.Cols; col++)
            //    {
            //        PictureBox pic = new PictureBox();
            //        pic.Width = Game.CubeSize;
            //        pic.Height = Game.CubeSize;
            //        pic.Left = Game.XGap + (pic.Width * col);
            //        pic.Top = Game.YGap + (pic.Height * row);
            //        pic.BorderStyle = BorderStyle.Fixed3D;
            //        pic.SizeMode = PictureBoxSizeMode.StretchImage;

            //        Game.Cubes[row, col] = pic;
            //        Game.SpcBoard.Panel2.Controls.Add(pic);

            //        // differentiates behavior of cube click event between
            //        // when play and design
            //        if (!Game.IsPlay)
            //        {
            //            pic.Click += EventHandler.Cube_Click;
            //        }
            //        else
            //        {
            //            pic.Click += EventHandler.PlayCursor_Click;
            //        }
            //        Game.XGap += Game.Gap;
            //    }
            //    Game.XGap = Game.XStart;
            //    Game.YGap += Game.Gap;
            //}
            //Game.YGap = Game.YStart;

            //test with cube class
            for (int row = 0; row < Game.Rows; row++)
            {
                for (int col = 0; col < Game.Cols; col++)
                {
                    Cube cube = new Cube();
                    cube.Width = Game.CubeSize;
                    cube.Height = Game.CubeSize;
                    cube.Left = Game.XGap + (cube.Width * col);
                    cube.Top = Game.YGap + (cube.Height * row);
                    cube.BorderStyle = BorderStyle.Fixed3D;
                    cube.SizeMode = PictureBoxSizeMode.StretchImage;

                    cube.X = row;
                    cube.Y = col;

                    Game.Cubes[row, col] = cube;
                    Game.SpcBoard.Panel2.Controls.Add(cube);

                    // differentiates behavior of cube click event between
                    // when play and design
                    if (!Game.IsPlay)
                    {
                        cube.Click += EventHandler.Cube_Click;
                    }
                    else
                    {
                        cube.Click += EventHandler.PlayCursor_Click;
                    }
                    Game.XGap += Game.Gap;
                }
                Game.XGap = Game.XStart;
                Game.YGap += Game.Gap;
            }
            Game.YGap = Game.YStart;
        }
    }
}
