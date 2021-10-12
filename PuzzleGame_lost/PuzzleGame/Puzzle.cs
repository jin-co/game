using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Puzzle : Form
    {
        public Puzzle()
        {
            InitializeComponent();
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Design design = new Design();
            design.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play play = new Play();
            play.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
