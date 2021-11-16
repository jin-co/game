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
        private Game game;
        private int rows, cols;
        public GamePlay()
        {
            InitializeComponent();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            game = new Game(spcPlayBoard, imageList1);
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string loadString = FileHandler.LoadFile();                        
            Game.Rows = int.Parse(loadString[0].ToString());
            Game.Cols = int.Parse(loadString[1].ToString());
            Game.Cubes = new PictureBox[Game.Rows, Game.Cols];
            GameGenerator.GenerateGame();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
