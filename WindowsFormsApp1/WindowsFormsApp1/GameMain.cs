using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameMain : Form
    {
        private int numberOfImages = 0;
        public GameMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int row;
            if (int.TryParse(txtRows.Text, out row))
            {
                txtMessage.Text += "not integer";
            }

            try
            {
                int.Parse(txtRows.Text);
                int.Parse(txtColumns.Text);
            }
            catch (Exception error)
            {                
                txtMessage.Text = error.Message;
                txtRows.Text = "";
                txtColumns.Text = "";
            }

            int rows = int.Parse(txtRows.Text);
            int cols = int.Parse(txtColumns.Text);
            if (rows * cols > numberOfImages)
            {
                txtMessage.Text = "image number error";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
