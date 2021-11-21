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
            imageList1.Images.Add(Resources.none);
            imageList1.Images.Add(Resources.wall);
            imageList1.Images.Add(Resources.reddoor);
            imageList1.Images.Add(Resources.greendoor);
            imageList1.Images.Add(Resources.redbox);
            imageList1.Images.Add(Resources.greenbox);
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            new Game(spcPlayBoard, imageList1);
            Game.BoxesLeftDisplay = txtNumberOfRemainingBoxes;
            Game.MovementDisplay = txtNumberOfMoves;
            Game.IsPlay = true;
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string loadString = FileHandler.LoadFile();
            Game.LoadString = FileHandler.LoadFile();
            Game.Rows = int.Parse(Game.LoadString[0].ToString());
            Game.Cols = int.Parse(Game.LoadString[1].ToString());
            Game.Cubes = new Cube[Game.Rows, Game.Cols];            

            GameGenerator.GenerateGame();

            // remaining box
            Game.BoxesLeftDisplay.Text = GameScore.BoxCount.ToString();
        }

        private void Cursor_Click(object sender, EventArgs e)
        {
            EventCatcher.Cursor_Click(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
