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
    // class that allows users to play a saved game
    public partial class GamePlay : Form
    {
        // storing images to a image list
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

        /// <summary>
        /// On load generate a game object with play board, image list,
        /// display text boxes for general use, and a flag that sets play
        /// from design set to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GamePlay_Load(object sender, EventArgs e)
        {
            new Game(spcPlayBoard, imageList1);
            Game.BoxesLeftDisplay = txtNumberOfRemainingBoxes;
            Game.MovementDisplay = txtNumberOfMoves;
            Game.IsPlay = true;
        }

        /// <summary>
        /// Loads file for generating a game to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler.LoadFile();
            GameGenerator.GenerateGame();

            // remaining box
            Game.BoxesLeftDisplay.Text = GameScore.BoxCount.ToString();
            txtNumberOfMoves.Text = "0";
        }

        /// <summary>
        /// handles cursor click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cursor_Click(object sender, EventArgs e)
        {
            EventCatcher.Cursor_Click(sender, e);
        }

        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
