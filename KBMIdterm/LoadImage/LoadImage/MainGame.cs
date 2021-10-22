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
        string path = Path.GetFullPath(@"../../..");
        Image[] images = new Image[5];
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            btnFirst.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnLast.Visible = true;
            btnPlay.Visible = false;
            btnStop.Visible = false;

            // load images1
            for (int i = 0; i < 5; i++)
            {
                string fname = "image" + (i + 1) + ".jpg"; // fname = $"p{n}.jpg";
                string path = Path.GetFullPath(@"../../..");
                images[i] = Image.FromFile($@"{path}/images/{fname}");
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            

            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Puzzle Game Data (*.puzzle)|*.puzzle";
            //string filePath = @"c:/5555/puzzle/data";
            //ofd.InitialDirectory = filePath;

            //string[] lines = new string[rows * cols + 1];
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader sr = new StreamReader(ofd.FileName);
            //    for (int n = 0; n < rows * cols + 1; n++)
            //    {
            //        lines[n] = sr.ReadLine();
            //    }
            //}
            //return lines;
        }

        private void btnAutomatic_Click(object sender, EventArgs e)
        {
            btnFirst.Visible = false;
            btnPrevious.Visible = false;
            btnNext.Visible = false;
            btnLast.Visible = false;
            btnPlay.Visible = true;
            btnStop.Visible = true;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            btnFirst.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnLast.Visible = true;
            btnPlay.Visible = false;
            btnStop.Visible = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (images == null)
            {
                MessageBox.Show("No Image added");
            }
            ptbSlider.Image = images[0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (images == null)
            {
                MessageBox.Show("No Image added");
            }
            int idx = Array.IndexOf(images, ptbSlider.Image);
            if (idx != 0)
            {
                idx--;
                ptbSlider.Image = images[idx];
            }
            txtTest.Text = idx.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (images == null)
            {
                MessageBox.Show("No Image added");
            }
            int idx = Array.IndexOf(images, ptbSlider.Image);
            if (idx != 4)
            {
                idx++;
                ptbSlider.Image = images[idx];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (images == null)
            {
                MessageBox.Show("No Image added");
            }
            ptbSlider.Image = images[images.Length - 1];
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (images == null)
            {
                MessageBox.Show("No Image added");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }


    }
}
