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
    public partial class Design : Form
    {
        private FileIO fileIO; 
        private Game2DGen genGame;
        public Design()
        {
            InitializeComponent();
        }

        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void level13X3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuzzleData.currentLevel = 1;
            genGame.GenWidget();
            genGame.ShowGame();
        }

        private void Design_Load(object sender, EventArgs e)
        {
            genGame = new Game2DGen(this);
            fileIO = new FileIO();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileIO.SaveGame();
        }
    }
}
