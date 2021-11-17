using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Game design form that controls game design parts.
     * It connects all different classes related to the
     * generation of the game as well as file handling 
     */
    public partial class GameDesign : Form
    {
        private int rows, cols;

        public GameDesign()
        {
            InitializeComponent();
        }
        
        // On load instantiate the Game class
        private void GameDesign_Load(object sender, EventArgs e)
        {
            new Game(spcBoard, imageList);
        }

        // Generates cubes based on the rows and columns 
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // checks input error
            if (!int.TryParse(txtRows.Text, out rows) || !int.TryParse(txtCols.Text, out cols))
            {
                GameMessage.ShowMessage(1, "Please provide numbers for rows and columns");
            }
            Game.Rows = rows;
            Game.Cols = cols;
            // sets array size
            Game.Cubes = new Cube[rows, cols];
            GameGenerator.GenerateGame();
        }

        // Saves the game design
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler.SaveFile();            
        }

        // Closes the design form
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Handles click event for buttons in the toolbox
        private void ToolBox_Click(object sender, EventArgs e)
        {
            EventHandler.ToolBox_Click(sender, e);
        }
    }
}
