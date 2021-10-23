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
    /* Author: Kwangjin Baek
     * Date: 2021. Oct. 22.
     * Description: Image slider application that allows 
     *      users to add and show the images using 
     *      buttons with two view options
     */

    public partial class MainGame : Form
    {
        #region variables
        string path = Path.GetFullPath(@"../../..");
        List<Image> images = new List<Image>();
        #endregion

        public MainGame()
        {
            InitializeComponent();
        }

        // on load, the app starts with manual mode(play, stop not showing)
        private void MainGame_Load(object sender, EventArgs e)
        {
            btnFirst.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnLast.Visible = true;
            btnPlay.Visible = false;
            btnStop.Visible = false;
        }

        // adds images to the list to be used in slider
        // shows a message when an image is added
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //filter the file
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

        // changes to 'auto' mode(shows play and stop buttons only)
        private void btnAutomatic_Click(object sender, EventArgs e)
        {
            btnFirst.Visible = false;
            btnPrevious.Visible = false;
            btnNext.Visible = false;
            btnLast.Visible = false;
            btnPlay.Visible = true;
            btnStop.Visible = true;
        }

        // changes to 'manual' mode(hides play and stop buttons)
        private void btnManual_Click(object sender, EventArgs e)
        {
            btnFirst.Visible = true;
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnLast.Visible = true;
            btnPlay.Visible = false;
            btnStop.Visible = false;
        }

        // show the first image only if the image list is not empty
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

        // allows users to move to the previous image
        // only if the image list is not empty
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

        // allows users to move to the next image
        // only if the image list is not empty
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

        // show the last image only if the image list is not empty
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

        // automatically move through the images
        // only if the image list is not empty
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (images.Count == 0)
            {
                MessageBox.Show("No Image added", "Image Viewer");
            }
            else
            {
                timerSlider.Start();
                timerSlider.Interval = 1000;
            }
        }

        // stop the slide show
        private void btnStop_Click(object sender, EventArgs e)
        {
            timerSlider.Stop();
        }

        private void timerSlider_Tick(object sender, EventArgs e)
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
