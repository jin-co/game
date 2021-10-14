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

namespace WindowsFormsApp1
{
    public partial class GameMain : Form
    {
        private int numberOfImages = 0;
        public GameMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //int row;
            //if (int.TryParse(txtRows.Text, out row))
            //{
            //    txtMessage.Text += "not integer";
            //}

            try
            {
                int.Parse(txtRows.Text);
                int.Parse(txtColumns.Text);
            }
            catch (Exception error)
            {                
                txtMessage.Text = error.Message;
                txtRows.Text = "";
                txtColumns.Text = "";
            }

            int rows = int.Parse(txtRows.Text);
            int cols = int.Parse(txtColumns.Text);
            if (rows * cols > numberOfImages)
            {
                txtMessage.Text = "image number error";
            }

            int gridWidth = grbGrid.Width / cols -2;
            int gridHeight = grbGrid.Height / rows -2;

            Image[,] images = new Image[rows, cols];
            int index = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string fileName = $"p{index}.jpg";
                    index++;
                    string path = Path.GetFullPath(@"../../..");
                    images[row, col] = Image.FromFile($@"{path}/images/{fileName}");
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
                    PictureBox pic = new PictureBox();
                    pic.Left = x;
                    pic.Top = y;
                    pic.Height = gridHeight;
                    pic.Width = gridWidth;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = images[row, col];
                    grbGrid.Controls.Add(pic);

                    x += gridWidth + 2;
                }
                x = startY;
                y += gridHeight;
            }
            y = startY;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
