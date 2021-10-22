using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBMidterm
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnFirst.Visible = true;
            //btnPrevious.Visible = true;
            //btnNext.Visible = true;
            //btnLast.Visible = true;
            //btnPlay.Visible = false;
            //btnStop.Visible = false;
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
    }
}
