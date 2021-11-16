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
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string loadString = FileHandler.LoadFile();
            char[] loadString = FileHandler.LoadFile().ToCharArray();
            Game.Rows = int.Parse(loadString[0].ToString());
            Game.Cols = int.Parse(loadString[1].ToString());
            Game.Cubes = new PictureBox[Game.Rows, Game.Cols];
            GameGenerator.GenerateGame();
            for (int i = 2, j = 3, k = 4; k < loadString.Length; i += 3, j += 3, k +=3)
            {
                if (int.Parse(loadString[k].ToString()) != 0)
                {
                    Game.Cubes[int.Parse(loadString[i].ToString()), 
                        int.Parse(loadString[j].ToString())].Image = 
                        Game.ImageList.Images[int.Parse(loadString[k].ToString())];
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CursorDown_Click(object sender, EventArgs eventArgs)
        {

        }
    }
}
