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
    class EventHandler
    {
        #region Properties
        public static Image ToolBoxPic { get; set; }
        public static int ImageTag { get; set; }

        public static PictureBox CubeClicked { get; set; } // test
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
            PictureBox clicked = (PictureBox)sender;
            if (clicked.Image != null)
            {
                if ((clicked.Image.Tag).ToString() == "4")
                {
                    MessageBox.Show("red");
                    Game.IsMove = true;

                    CubeClicked = clicked;
                }

                if ((clicked.Image.Tag).ToString() == "5")
                {
                    MessageBox.Show("green");
                    Game.IsMove = true;
                    CubeClicked = clicked;
                }
            }
        }

        //test
        public static void Cursor_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (Game.IsMove)
            {
                switch (clicked.Text)
                {
                    case "Up":
                        MessageBox.Show(clicked.Text);
                        break;

                    case "Down":
                        MessageBox.Show(clicked.Text);
                        break;

                    case "Right":
                        MessageBox.Show(clicked.Text);
                        break;

                    case "Left":
                        MessageBox.Show(clicked.Text);
                        break;
                }
            }
            else
            {

            }
          
        }

        #endregion
    }
}
