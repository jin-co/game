using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    public partial class GamePlay : Form
    {
        public GamePlay()
        {
            InitializeComponent();
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler.LoadFile();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
