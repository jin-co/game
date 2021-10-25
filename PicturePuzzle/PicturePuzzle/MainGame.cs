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

namespace PicturePuzzle
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("images");
            string path2 = Path.GetFullPath(@"../../../");
            string fileName = Path.GetFileName("p1.jpg");
            PictureBox pic = new PictureBox();
            pic.Width = 140;
            pic.Height = 140;
            pic.Left = (this.Width / 2) - (pic.Width / 2);
            pic.Top = (this.Height / 2) - (pic.Height / 2);
            //pic.BackColor = Color.Red;
            rtbTest.Text = path + "\n" + fileName + "\n" + path2;
            pic.Image = Image.FromFile($@"{path2}PicturePuzzle\images\p1.jpg");
            this.Controls.Add(pic);
        }
    }
}
