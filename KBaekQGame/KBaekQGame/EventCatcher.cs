using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Class that handles events
     */
    class EventCatcher
    {
        #region Properties
        public static Image ToolBoxPic { get; set; }
        public static int ImageTag { get; set; }
        
        public static Timer CubeTimer { get; set; }

        public static Cube CubeClicked { get; set; } // test
        #endregion

        #region Methods     
        /// <summary>
        /// Event handler that fills the game board with the
        /// image chosen from the tool box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Cube_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;
            clicked.Image = ToolBoxPic;
            clicked.Tag = ImageTag;
        }

        /// <summary>
        /// Event handler that selects a image from the tool box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ToolBox_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ImageIndex == 0)
            {
                ToolBoxPic = null;
                ImageTag = 0;
                return;
            }
            ToolBoxPic = Game.ImageList.Images[btn.ImageIndex];
            ImageTag = btn.ImageIndex;
        }

        //test
        public static void PlayCursor_Click(object sender, EventArgs e)
        {
            Cube clicked = (Cube)sender;
            if (clicked.Image != null)
            {
                if ((clicked.Image.Tag).ToString() == "4")
                {
                    Game.IsMove = true;
                    CubeClicked = clicked;
                    ToolBoxPic = clicked.Image;
                }

                if ((clicked.Image.Tag).ToString() == "5")
                {
                    Game.IsMove = true;
                    CubeClicked = clicked;
                    ToolBoxPic = clicked.Image;
                }
            }
        }

        //test
        public static void Cursor_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            CubeTimer = new Timer();
            CubeTimer.Interval = 150;
            
            if (Game.IsMove)
            {
                CubeTimer.Enabled = true;
                CubeTimer.Start();
                switch (clicked.Text)
                {
                    case "Up":                        
                        CubeTimer.Tick += new EventHandler(Top_Tick);                                                        
                        break;

                    case "Down":                        
                        CubeTimer.Tick += new EventHandler(Bottom_Tick);                                                        
                        break;

                    case "Right":                        
                        CubeTimer.Tick += new EventHandler(Right_Tick);                                                        
                        break;

                    case "Left":                        
                        CubeTimer.Tick += new EventHandler(Left_Tick);                                                        
                        break;
                }
            }
            else
            {
                GameMessage.ShowMessage(3, "Select a box to move first");
            }  
        }

        public static void Top_Tick(object sender, EventArgs eventArgs)
        {
            if (!Wall.DetectCollision(CubeClicked) &&
                !Cube.DetectCollision(CubeClicked))
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Top -= Game.CubeSize;
            }
            else
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Top += Game.CubeSize;
                CubeTimer.Stop();
            }
        }

        public static void Bottom_Tick(object sender, EventArgs eventArgs)
        {


            if (!Wall.DetectCollision(CubeClicked) &&
                !Cube.DetectCollision(CubeClicked))
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Top += Game.CubeSize;
            }
            else
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Top -= Game.CubeSize;
                CubeTimer.Stop();
            }
        }

        public static void Right_Tick(object sender, EventArgs eventArgs)
        {


            if (!Wall.DetectCollision(CubeClicked) &&
                !Cube.DetectCollision(CubeClicked))
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Left += Game.CubeSize;
            }
            else
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Left -= Game.CubeSize;
                CubeTimer.Stop();
            }
        }

        public static void Left_Tick(object sender, EventArgs eventArgs)
        {


            if (!Wall.DetectCollision(CubeClicked) &&
                !Cube.DetectCollision(CubeClicked))
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Left -= Game.CubeSize;
            }
            else
            {
                Game.Cubes[CubeClicked.X, CubeClicked.Y].Left += Game.CubeSize;
                CubeTimer.Stop();
            }
        }

        #endregion
    }
}
