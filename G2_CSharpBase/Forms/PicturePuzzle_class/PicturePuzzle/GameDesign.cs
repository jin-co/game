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
    public partial class GameDesign : Form
    {
        private FileIO fileIo;
        private GameGenerator generator;
        public GameDesign()
        {
            InitializeComponent();
        }

        private void mnsLevel1_Click(object sender, EventArgs e)
        {
            PuzzleData.CurrentLevel = 1;
            generator.GenWidgets();
            generator.ShowGame();
        }

        private void mnsLevel2_Click(object sender, EventArgs e)
        {

        }

        private void mnsSave_Click(object sender, EventArgs e)
        {
            fileIo.SaveGame();
        }

        private void mnsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GameDesign_Load(object sender, EventArgs e)
        {
            generator = new GameGenerator(this);
            fileIo = new FileIO();
        }
    }
}
