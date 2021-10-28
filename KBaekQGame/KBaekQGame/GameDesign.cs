using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Game design form that creates initial game board
     * depending on the user input
     */
    public partial class GameDesign : Form
    {
        // variables
        int rows, cols, xGap, yGap, gap = 1, blockSize = 45, xStart, yStart, imageTag;

        // list
        PictureBox[,] cubes = new PictureBox[,] { };

        // temporary image 
        Image toolBoxPic;
        //PictureBox temp = new PictureBox();

        // test
        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        public GameDesign()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates cubes based on the rows and columns 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // clear game board
            spcBoard.Panel2.Controls.Clear();

            // checks input error
            if (!int.TryParse(txtRows.Text, out rows) || !int.TryParse(txtCols.Text, out cols))
            {
                GameMessage.ShowMessage(1, "Please provide numbers for rows and columns");
            }

            // sets array size
            cubes = new PictureBox[rows, cols];

            // sets starting point
            xStart = (spcBoard.Panel2.Width / 2) - ((cols / 2) * (blockSize + gap));
            yStart = (spcBoard.Panel2.Height / 2) - ((rows / 2) * (blockSize + gap));
            xGap = xStart;
            yGap = yStart;

            // generates board
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = blockSize;
                    pic.Height = blockSize;
                    pic.Left = xGap + (pic.Width * col);
                    pic.Top = yGap + (pic.Height * row);
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    cubes[row, col] = pic;
                    spcBoard.Panel2.Controls.Add(pic);
                    pic.Click += Cube_Click;
                    xGap += gap;
                }
                xGap = xStart;
                yGap += gap;
            }
            yGap = yStart;
        }

        /// <summary>
        /// Saves the game design
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.Rows = rows;
            fileHandler.Cols = cols;
            fileHandler.Cubes = cubes;
            fileHandler.SaveFile();

            int wallCount = 0, doorCount = 0, boxCount = 0;
            foreach (var i in cubes)
            {
                if (i.Tag != null)
                {
                    int tag = int.Parse(i.Tag.ToString());
                    if (tag == 1)
                    {
                        wallCount++;
                    }

                    if (tag == 2 || tag == 3)
                    {
                        doorCount++;
                    }

                    if (tag == 4 || tag == 5)
                    {
                        boxCount++;
                    }
                }
            }
            GameMessage.ShowMessage(0, $"File Saved Successfully\n" +
                    $"Walls: {wallCount} \nDoors: {doorCount} \nBoxes: {boxCount}");
        }

        /// <summary>
        /// Closes the design form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
          
        /// <summary>
        /// Selects the image chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cube_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;
            clicked.Image = toolBoxPic;
            clicked.Tag = imageTag;
        }

        private void ToolBox_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ImageIndex == 0)
            {
                toolBoxPic = null;
                return;
            }
            toolBoxPic = imageList.Images[btn.ImageIndex];
            imageTag = btn.ImageIndex;
        }        
    }
}
