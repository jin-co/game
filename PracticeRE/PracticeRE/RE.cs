using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeRE
{
    // Game app
    public partial class RE : Form
    {
        Rabbit rabbit = new Rabbit();
        Eagles eagles = new Eagles();
        Game game = new Game();
        int alarmCount = 0;

        // initializes 
        public RE()
        {
            InitializeComponent();
            rabbit.RabbitPic = ptbRabbit;
            rabbit.StartingPoint = new Point(ptbRabbit.Left, ptbRabbit.Top);

            eagles.EaglesPic = new PictureBox[] {
                ptbEagle1,
                ptbEagle2,
                ptbEagle3,
                ptbEagle4,
                ptbEagle5,
                ptbEagle6
            };

            eagles.StartingPoint = new Point[] {
                ptbEagle1.Location,
                ptbEagle2.Location,
                ptbEagle3.Location,
                ptbEagle4.Location,
                ptbEagle5.Location,
                ptbEagle6.Location
            };
        }

        private void RE_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            btnNewGame.Visible = false;
            lblGameOver.Visible = false;
        }

        // moves eagles and tracks timer
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // timer
            gameTimer.Interval = 1000;
            alarmCount += 1;
            gameTimer.Start();
            lblTime.Text = alarmCount.ToString();

            // eagle move
            eagles.UpdatePosition();

            // Test
            txtTest.Text =
                $"rabbit left: {rabbit.RabbitPic.Left.ToString()}\t" +
                $"rabbit right: {rabbit.RabbitPic.Right.ToString()}\t" +
                $"parent width: {rabbit.RabbitPic.Parent.Width}\t" +
                $"rabbit width: {rabbit.RabbitPic.Width}";

            // gameover
            foreach (var i in eagles.EaglesPic)
            {
                if (rabbit.RabbitPic.Bounds.IntersectsWith(i.Bounds))
                {
                    gameTimer.Enabled = false;
                    lblGameOver.Visible = true;
                    btnNewGame.Visible = true;
                    rabbit.GameOver = true;
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblGameOver.Visible = false;
            btnNewGame.Visible = false;
            rabbit.GameOver = false;
            eagles.resetEaglePosition();
            rabbit.resetRabbitPosition();
            gameTimer.Start();
        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    rabbit.GoLeft = true;
                    eagles.GoLeft = true;
                    rabbit.UpdatePosition();
                    return true;

                case Keys.Right:
                    rabbit.GoLeft = false;
                    eagles.GoLeft = false;
                    rabbit.UpdatePosition();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
