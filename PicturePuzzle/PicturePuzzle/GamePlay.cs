using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzle
{
    public partial class GamePlay : Form
    {
        private FileIO fileIO;
        private GameGenerator generator;
        private GameEventHandler eventHandler;
        public GamePlay()
        {
            InitializeComponent();
        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            fileIO = new FileIO();
            generator = new GameGenerator(this);
            eventHandler = new GameEventHandler();
        }

        private void mnsLoad_Click(object sender, EventArgs e)
        {
            string[] lines = fileIO.LoadGame();
            generator.LoadPuzzleFromFile(lines);
        }

        private void mnsSave_Click(object sender, EventArgs e)
        {
            fileIO.SaveGame();
        }

        private void mnsExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnScramble_Click(object sender, EventArgs e)
        {
            // game handle will do that
            eventHandler.Scramble();
        }


    }
}
