using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHorseRace
{
    public partial class HorseRace : Form
    {
        int numberOfHorses = 0;
        Button[] horses = new Button[] { };
        int second = 0;
        public HorseRace()
        {
            InitializeComponent();
        }

        private void HorseRace_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            horseTimer.Enabled = true;
            horseTimer.Start();
            horseTimer.Tick += new EventHandler(gameTimer_Tick);
            gameTimer.Enabled = true;
            gameTimer.Start();
            gameTimer.Tick += new EventHandler(horseTimer_Tick);

            numberOfHorses = int.Parse(txtNumberOfHorses.Text);
            horses = new Button[numberOfHorses];
            for (int i = 0; i < numberOfHorses; i++)
            {
                horses[i] = new Button();
                horses[i].Image = Resources.horse;
                horses[i].Height = 50;
                horses[i].Width = 50;
                horses[i].Top = 150 + (i * 50);
                horses[i].Left = 50;
                horses[i].AutoSizeMode = AutoSizeMode.GrowAndShrink;
                horses[i].AutoSize = true;

                this.Controls.Add(horses[i]);
            }
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            Button n = new Button();
            n.Height = 20;
            n.Width = 20;
            this.Controls.Add(n);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            HorseRace horseRace = new HorseRace();
            horseRace.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;

            foreach (var i in horses)
            {
                i.Left += 10;
            }
        }

        private void horseTimer_Tick(object sender, EventArgs e)
        {
            horseTimer.Interval = 100;
            second++;
            txtTest.Text = second.ToString();
        }
    }
}
