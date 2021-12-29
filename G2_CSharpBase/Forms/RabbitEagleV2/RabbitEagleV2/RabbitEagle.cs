using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagleV2
{
    public partial class RabbitEagle : Form
    {
        private Player player;
        private Eagles eagles;
        private Timer timer = new Timer();

        public RabbitEagle()
        {
            InitializeComponent();
            timer.Enabled = false;
        }

        private void RabbitEagle_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(Timer_Tick);
            //timer.Enabled = true;

            player = new Player(this, 50, 50);
            player.LoadContent();
            eagles = new Eagles(this, 50, 50);
            eagles.LoadContent();

            player.goLeft = true;
            eagles.goLeft = true;
            eagles.playerMoved = true;
            player.Update();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            eagles.Update();
            // check collision
            GameOver();
        }

        private void GameOver()
        {
            foreach (var i in eagles.eaglesPic)
            {
                if (player.Rabbit.Bounds.IntersectsWith(i.Bounds))
                {
                    eagles.playerMoved = false;
                    btnNewGame.Visible = true;
                    lblGameOver.Visible = true;
                    timer.Enabled = false;
                    break;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                player.goLeft = true;
                eagles.goLeft = true;
                eagles.playerMoved = true;
                player.Update();
                return true;
            }
            else if (keyData == Keys.Right)
            {
                player.goLeft = false;
                eagles.goLeft = false;
                eagles.playerMoved = true;
                player.Update();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            btnNewGame.Visible = false;
            lblGameOver.Visible = false;
            
            player.UnloadContent();
            player.LoadContent();

            eagles.UnloadContent();
            eagles.LoadContent();

            //eagles.playerMoved = false;
        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
