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
    public partial class DesignGame : Form
    {
        private FileHandler fileHandler;
        private Game2DGen genGame;

        public DesignGame()
        {
            InitializeComponent();
        }

        private void DesignGame_Load(object sender, EventArgs e)
        {
            genGame = new Game2DGen(this);
            fileHandler = new FileHandler();
        }

        private void designToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void level13X3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PuzzleData.CurrentLevel = 1;
            genGame.GenWidgets();
            genGame.ShowGame();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileHandler.SaveGame();
        }
    }
}
