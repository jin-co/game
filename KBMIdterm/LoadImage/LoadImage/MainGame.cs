using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadImage
{
    public partial class MainGame : Form
    {
        string path = Path.GetFullPath(@"../../..");
        //Image[] images = new Image[5];
        List<Image> images = new List<Image>();
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
            //for (int i = 0; i < 5; i++)
            //{
            //    string fname = "image" + (i + 1) + ".jpg"; // fname = $"p{n}.jpg";
            //    string path = Path.GetFullPath(@"../../..");
            //    images.Add(Image.FromFile($@"{path}/images/{fname}"));
            //}
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //filter the file you want to get
            ofd.Filter = "img (*.jpg)|*.jpg|All files (*.*)|*.*";
            //set an intial directory
            ofd.InitialDirectory = path + @"images";
            //Put the title in the dialog box
            ofd.Title = "Please select an image.";
            //validating result
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //load the image in the picture box
                images.Add(Image.FromFile(ofd.FileName));

                //message
                MessageBox.Show("Image added\n" +
                    "Total images added so far: " + images.Count, "Image Viewer");
            }
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
            if (images.Count == 0)
            {
                MessageBox.Show("No Image added", "Image Viewer");
            }
            else
            {
                ptbSlider.Image = images[0];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                MessageBox.Show("No Image added", "Image Viewer");
            }
            else
            {
                int idx = images.IndexOf(ptbSlider.Image);
                if (idx <= 0)
                {
                    idx = 5;
                }
                idx--;
                ptbSlider.Image = images[idx];
            }     
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                MessageBox.Show("No Image added", "Image Viewer");
            }
            else
            {
                int idx = images.IndexOf(ptbSlider.Image);
                if (idx >= 4)
                {
                    idx = -1;
                }
                idx++;
                ptbSlider.Image = images[idx];            
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                MessageBox.Show("No Image added", "Image Viewer");
            }
            else
            {
                ptbSlider.Image = images[images.Count - 1];
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                MessageBox.Show("No Image added", "Image Viewer");
            }
            else
            {
                timer1.Start();
                timer1.Interval = 1000;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptbSlider.Image == images[0])
            {
                ptbSlider.Image = images[1];
            }
            else if (ptbSlider.Image == images[1])
            {
                ptbSlider.Image = images[2];
            }
            else if (ptbSlider.Image == images[2])
            {
                ptbSlider.Image = images[3];
            }
            else if (ptbSlider.Image == images[3])
            {
                ptbSlider.Image = images[4];
            }
            else
            {
                ptbSlider.Image = images[0];
            }
        }
    }
}
