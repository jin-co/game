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
        Button temp = new Button();
        int rows;
        int cols;
        Button[,] btns;
        List<Button> btnsList = new List<Button>();
        public Main()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
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
                    btn.Tag = num;
                    grbPics.Controls.Add(btn);
                    btns[row, col] = btn;

                    btnsList.Add(btn);
                    btn.Enabled = false;
                    
                    num++;
                    xGap += 20;
                    btns[row, col].MouseDown += this.MouseDown2;
                }
                xGap = 0;
                yGap += 20;
            }

            Button btnL = new Button();
            btnL.Left = btnsList[btnsList.Count - 1].Left;
            btnL.Top = btnsList[btnsList.Count - 1].Top + (10 + 40);
            btnL.Width = 40;
            btnL.Height = 40;
            btnsList.Add(btnL);
            grbPics.Controls.Add(btnL);
            num++;
            btnL.MouseDown += MouseDown2;

            checkPosition();
        }

        private void checkPosition()
        {
            closePosition();
            for (int i = 0; i < btnsList.Count; i++)
            {
                if (btnsList[i].Text == "")
                {
                    switch (i)
                    {
                        case 0:
                            btnsList[1].Enabled = true;
                            btnsList[3].Enabled = true;
                            break;
                        case 1:
                            btnsList[0].Enabled = true;
                            btnsList[2].Enabled = true;
                            btnsList[4].Enabled = true;
                            break;
                        case 2:
                            btnsList[1].Enabled = true;
                            btnsList[5].Enabled = true;
                            break;
                        case 3:
                            btnsList[0].Enabled = true;
                            btnsList[4].Enabled = true;
                            btnsList[6].Enabled = true;
                            break;
                        case 4:
                            btnsList[1].Enabled = true;
                            btnsList[3].Enabled = true;
                            btnsList[5].Enabled = true;
                            btnsList[7].Enabled = true;
                            break;
                        case 5:
                            btnsList[2].Enabled = true;
                            btnsList[4].Enabled = true;
                            btnsList[8].Enabled = true;
                            break;
                        case 6:
                            btnsList[3].Enabled = true;
                            btnsList[7].Enabled = true;
                            break;
                        case 7:
                            btnsList[4].Enabled = true;
                            btnsList[6].Enabled = true;
                            btnsList[8].Enabled = true;
                            break;
                        case 8:
                            btnsList[5].Enabled = true;
                            btnsList[7].Enabled = true;
                            break;
                        default:
                            btnsList[8].Enabled = true;
                            break;
                    }                    
                }
            }            
        }

        private void closePosition()
        {
            foreach (var i in btnsList)
            {
                i.Enabled = false;
            }
        }

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
            clicked.Text = "";            
        }

        public void MouseDown2(object sender, EventArgs eventArgs)
        {
            Button clicked = (Button)sender;

            if (clicked.Text != "")
            {
                foreach (var i in btnsList)
                {
                    if (i.Text == "")
                    {
                        i.Text = clicked.Text;
                        clicked.Text = "";
                    }
                }
            }
            checkPosition();
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
