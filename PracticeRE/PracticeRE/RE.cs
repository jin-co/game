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
    public partial class RE : Form
    {
        int alarmCount = 0;
        public RE()
        {
            InitializeComponent();
        }

        private void RE_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            btnNewGame.Visible = false;
            lblGameOver.Visible = false;
            

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;
            alarmCount += 1;
            gameTimer.Start();
            lblTime.Text = alarmCount.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

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
                    ptbRabbit.Left -= 1;
                    return true;

                case Keys.Right:
                    ptbRabbit.Left += 1;
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
