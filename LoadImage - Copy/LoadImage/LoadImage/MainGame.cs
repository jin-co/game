using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadImage
{
    public partial class MainGame : Form
    {
        private int noOfImages = 16;
        public MainGame()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtRows.Text);
                int.Parse(txtCols.Text);
            } catch (Exception ex)
            {
                Debug.WriteLine($"exception={ex.Message} stacktrace={ex.StackTrace}");
                txtRows.Text = "";
                txtCols.Text = "";
                MessageBox.Show("Please enter a valid number","Tips");
                return;
            }

            int rows = int.Parse(txtRows.Text);
            int cols = int.Parse(txtRows.Text);
            if (rows * cols > noOfImages)
            {
                MessageBox.Show("Please add more images or decrease the number to max 16 (Rows X Columns)");
                return;
            }

            int gridWidth = groupGrid.Width / cols - 2;
            int gridHeight = groupGrid.Height / rows - 2;

            Image[,] images = new Image[rows, cols];

            // load images
            int n = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string fname = "image" + n + ".jpg"; // fname = $"p{n}.jpg";
                    n++;
                    string path = Path.GetFullPath(@"../../..");
                    images[row, col] = Image.FromFile($@"{path}/images/{fname}");
                }
            }

            int startX = 0;
            int startY = 0;
            int x = startX;
            int y = startY;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox picBox = new PictureBox();
                    picBox.Left = x;
                    picBox.Top = y;
                    picBox.Width = gridWidth;
                    picBox.Height = gridHeight;
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Image = images[row, col];
                    groupGrid.Controls.Add(picBox);
                    // prepare for the next in the loop
                    x += gridWidth + 2;
                }
                x = startY;
                y += gridHeight + 2;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GroupBox g = new GroupBox();
            g.Left = groupGrid.Left;
            g.Top = groupGrid.Top;
            g.Width = groupGrid.Width;
            g.Height = groupGrid.Height;
            Controls.Remove(groupGrid);
            groupGrid = g;
            Controls.Add(groupGrid);
        }
    }
}
