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
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            Image[] images = new Image[5];

            // load images
            int max = 5;

            for (int i = 0; i < max; i++)
            {
                string fname = "image" + i + ".jpg"; // fname = $"p{i}.jpg";
                string path = Path.GetFullPath(@"../../..");
                images[i] = Image.FromFile($@"{path}/images/{fname}");
                MessageBox.Show(i + "added");
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
            string fname = "image" + 1 + ".jpg"; // fname = $"p{i}.jpg";
            Image image = Image.FromFile($@"{path}/images/{fname}");
            ptbSlider.Image = image;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            string fname = "image" + 5 + ".jpg"; // fname = $"p{i}.jpg";
            Image image = Image.FromFile($@"{path}/images/{fname}");
            ptbSlider.Image = image;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }


    }
}
