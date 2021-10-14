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
    public partial class PlayGame : Form
    {
        private FileHandler fileHandler;
        private Game2DGen gameGen;
        private GameEventHandler gameHandler;
        public PlayGame()
        {
            InitializeComponent();
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            fileHandler = new FileHandler();
            gameGen = new Game2DGen(this);
            gameHandler = new GameEventHandler();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string [] lines = fileHandler.LoadGame();
            gameGen.LoadPuzzleFromFile(lines);
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileHandler.SaveGame();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnScramble_Click(object sender, EventArgs e)
        {
            // game handle will do that
            gameHandler.Scramble();
        }
    }
}
