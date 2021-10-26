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
        string path = Path.GetFullPath("images");
        string path2 = Path.GetFullPath(@"../../../");
        string fileName = Path.GetFileName("p1.jpg");

        int xGap = 30;
        int yGap = 30;
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {            
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ptbWholePic.Image = Image.FromFile($@"{path2}PicturePuzzle\images\L1\M\whole.jpg");
            int n = 1;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Width = 140;
                    pic.Height = 140;
                    pic.Left = row * n;
                    pic.Top = col * n;
                    //pic.BackColor = Color.Red;
                    rtbTest.Text = path + "\n" + fileName + "\n" + path2;
                    pic.Image = Image.FromFile($@"{path2}PicturePuzzle\images\L1\M\m{n}.jpg");
                    n++;
                    grbBoard.Controls.Add(pic);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
