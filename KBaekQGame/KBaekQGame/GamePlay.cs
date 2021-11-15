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

        private void GamePlay_Load(object sender, EventArgs e)
        {
            Game game = new Game();
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string loadString = FileHandler.LoadFile();
            char x = loadString[0];
            char y = loadString[1];
            Game.Rows = int.Parse(x.ToString());
            Game.Cols = int.Parse(y.ToString());
            Game.Cubes = new PictureBox[int.Parse(x.ToString()), int.Parse(y.ToString())];
            GameGenerator.RegenerateGame(pnlPlayBoard);

            rtxTest.Text = loadString + ", " + x + ", " + y;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
