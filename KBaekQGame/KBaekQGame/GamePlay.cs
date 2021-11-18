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
            string loadString = FileHandler.LoadFile();
            Game.Rows = int.Parse(loadString[0].ToString());
            Game.Cols = int.Parse(loadString[1].ToString());
            Game.Cubes = new Cube[Game.Rows, Game.Cols];
            Game.IsPlay = true;

            GameGenerator.GenerateGame();

            int boxCount = 0;

            for (int i = 2, j = 3, k = 4; k < loadString.Length; i += 3, j += 3, k +=3)
            {
                if (int.Parse(loadString[k].ToString()) != 0)
                {
                    string tag = loadString[k].ToString();
                    Game.Cubes[int.Parse(loadString[i].ToString()), 
                        int.Parse(loadString[j].ToString())].Image = 
                        Game.ImageList.Images[int.Parse(loadString[k].ToString())];
                    Game.Cubes[int.Parse(loadString[i].ToString()),
                        int.Parse(loadString[j].ToString())].Image.Tag =
                        int.Parse(loadString[k].ToString());

                    // box count
                    if ((int.Parse(loadString[k].ToString())).ToString() == "4" || 
                        (int.Parse(loadString[k].ToString())).ToString() == "5")
                    {
                        boxCount++;
                    }
                }
            }
            // deletes boxes without a picture
            GameGenerator.RemoveEmptyBoxes();

            // Adds created walls to a list for collision test
            Wall.SetWalls();

            // Adds created cubes to each set of a list for collision test
            Cube.SetCubes();

            // remaining box
            txtNumberOfRemainingBoxes.Text = boxCount.ToString();
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
