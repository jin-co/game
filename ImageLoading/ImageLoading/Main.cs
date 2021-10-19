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

namespace ImageLoading
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PictureBox picBox = new PictureBox();
            picBox.Left = 0;
            picBox.Top = 0;
            string path = Path.GetFullPath(@"../../../");
            txtTest.Text = path;
            Image image = Image.FromFile($@"{path}/images/p1.jpg");
            picBox.Image = image;
            //C: \Users\jin\Documents\GitHub\game\ImageLoading\ImageLoading\images\p1.jpg
            picBox.Height = 100;
            picBox.Width = 100;
            this.Controls.Add(picBox);

        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
