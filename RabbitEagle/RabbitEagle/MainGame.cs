using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagle
{
    public partial class MainGame : Form
    {
        private Eagles eagles;
        private Rabbit rabbit;
        private int playerSpeed = 10;
        

        public MainGame()
        {
            InitializeComponent();
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            eagles.Update();
            GameOver();
        }

        private void GameOver()
        {
            eagles.rabbitStartToMove = false;
            foreach (PictureBox i in eagles.eagles)
            {
                if (ptbBRabbit.Bounds.IntersectsWith(i.Bounds))
                {
                    gametimer.Enabled = false;
                    btnNewGame.Visible = true;
                    lblGameEnd.Visible = true;
                }
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            gametimer.Enabled = true;
            btnNewGame.Visible = false;
            lblGameEnd.Visible = false;

            // create game artifacts
            eagles = new Eagles(this);
            PictureBox[] eaglesPic =
            {
                ptbBEagle1,
                ptbBEagle2,
                ptbBEagle3,
                ptbBEagle4,
                ptbBEagle5
            };
            eagles.eagles = eaglesPic;
            Point[] startPoint =
            {
                ptbBEagle1.Location,
                ptbBEagle2.Location,
                ptbBEagle3.Location,
                ptbBEagle4.Location,
                ptbBEagle5.Location,
            };
            eagles.startPosition = startPoint;
            eagles.rabbitStartToMove = false;

            rabbit = new Rabbit(this);
            rabbit.player = ptbBRabbit;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    eagles.rabbitStartToMove = true;
                    rabbit.goLeft = true;
                    eagles.goLeft = true;
                    return true;
                case Keys.Right:
                    eagles.rabbitStartToMove = true;
                    rabbit.goLeft = false;
                    eagles.goLeft = false;
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            gametimer.Enabled = true;
            btnNewGame.Visible = false;
            lblGameEnd.Visible = false;
            eagles.newGame = true;
        }
    }
}
