using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzle
{
    public partial class GameMain : Form
    {
        public GameMain()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GameDesign designForm = new GameDesign();
            designForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GamePlay playForm = new GamePlay();
            playForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
