using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int rows, cols, xGap, yGap, gap = 5, blockSize = 30, xStart, yStart;
        
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
                MessageBox.Show(                     
                    "Please provide numbers for rows and columns",
                    "Q Game",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // test
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
                    spcBoard.Panel2.Controls.Add(pic);
                    xGap += gap;
                }
                xGap = xStart;
                yGap += gap;
            }
            yGap = yStart;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
