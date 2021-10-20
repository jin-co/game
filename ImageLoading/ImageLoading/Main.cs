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
            //PictureBox picBox = new PictureBox();
            //picBox.Left = 0;
            //picBox.Top = 0;
            //string path = Path.GetFullPath(@"../../../");
            //txtTest.Text = path;
            //Image image = Image.FromFile($@"{path}images/p1.jpg");
            //picBox.Image = image;
            ////C: \Users\jin\Documents\GitHub\game\ImageLoading\ImageLoading\images\p1.jpg
            //picBox.Height = 100;
            //picBox.Width = 100;
            //this.Controls.Add(picBox);



            int rows;
            int cols;
            int x = 30;
            int y = 30;
            int gap = 20;

            if (!int.TryParse(txtRows.Text, out rows))
            {
                MessageBox.Show("enter row and col");
            }
            if (!int.TryParse(txtRows.Text, out cols))
            {
                MessageBox.Show("enter row and col");
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button btn = new Button();
                    btn.Left = (col * x);
                    btn.Top = (row * y);
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Text = "btn";   
                    grbPics.Controls.Add(btn);
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Left = grbPics.Left;
            groupBox.Top = grbPics.Top;
            groupBox.Width = grbPics.Width;
            groupBox.Height = grbPics.Height;
            Controls.Remove(grbPics);
            grbPics = groupBox;
            Controls.Add(grbPics);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(".");

            rtbPath.Text += $"{currentDirectory.FullName}\n";
            rtbPath.Text += $"{currentDirectory.Name}\n";
            rtbPath.Text += $"{currentDirectory.Parent}\n";
            rtbPath.Text += $"{currentDirectory.Attributes}\n";
            rtbPath.Text += $"{currentDirectory.CreationTimeUtc}\n";

            /* Creating directory */
            DirectoryInfo createDir = new DirectoryInfo(@"C:Users\jin\TESTDIR");
            rtbPath.Text += $"{createDir.FullName}\n";

            /* Delete directory */
            //Directory.Delete(@"C:Users\jin\TESTDIR");

            /* Write */




        }
    }
}
