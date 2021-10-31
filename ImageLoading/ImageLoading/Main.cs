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
        Button fromBtn;
        Button toBtn;
        Button temp = new Button();
        int rows;
        int cols;
        Button[,] btns; 
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

            int xGap = 0;
            int yGap = 0;
            int num = 1;
            int x = 30;
            int y = 30;

            if (!int.TryParse(txtRows.Text, out rows))
            {
                MessageBox.Show("enter row and col");
            }
            if (!int.TryParse(txtRows.Text, out cols))
            {
                MessageBox.Show("enter row and col");
            }

            btns = new Button[rows + 1, cols];
            int row;
            for (row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button btn = new Button();
                    btn.Left = (col * x) + xGap;
                    btn.Top = (row * y) + yGap;
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Text = num.ToString(); 
                    grbPics.Controls.Add(btn);
                    btns[row, col] = btn;
                    num++;
                    xGap += 20;
                    btns[row, col].MouseDown += this.MouseDown;
                }
                xGap = 0;
                yGap += 20;
            }

            for (int col = 0; col < cols; col++)
            {
                Button btn = new Button();
                btn.Left = (col * x) + xGap;
                btn.Top = (row * y) + yGap;
                btn.Width = 40;
                btn.Height = 40;
                grbPics.Controls.Add(btn);
                btns[row, col] = btn;
                num++;
                xGap += 20;
                btns[row, col].MouseDown += MouseDown;
            }
        }

        // this doesn't work
        //private void Main_Load(object sender, EventArgs e)
        //{
        //    for (int row = 0; row < rows; row++)
        //    {
        //        for (int col = 0; col < cols; col++)
        //        {
        //            //btns[row, col].Click += new System.EventHandler(this.MouseDown);
        //            btns[row, col].Click += new System.EventHandler(this.MouseDown);
        //        }
        //    }
        //}

        public void MouseDown (object sender, EventArgs eventArgs)
        {
            Button clicked = (Button)sender;
            if (temp.Text == "" || temp.Text == null)
            {
                temp.Text = clicked.Text;
            }
            else
            {
                if (clicked.Text == "" || clicked.Text == null)
                {
                    clicked.Text = temp.Text;
                    temp.Text = "";
                }
                return;
            }

            if (clicked.Text == "" || clicked.Text == null)
            {
                clicked.Text = temp.Text;
                temp.Text = "";
            }            
            else
            {
                clicked.Text = "";
            }

            txtTest.Text = clicked.Text;
            txtTest.Text += temp.Text;
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
