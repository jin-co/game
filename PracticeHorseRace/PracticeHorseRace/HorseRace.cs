using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHorseRace
{
    /* horse race game
     * 
     * 
     */
    public partial class HorseRace : Form
    {
        private static int nThGame = 1;
        private List<Horse> horses;
        private const int MIN_SPEED = 5;
        private const int MAX_SPEED = 20;
        private const int MIN_TICK_INT = 200;
        private const int MAX_TICK_INT = 600;
        
        public HorseRace()
        {
            InitializeComponent();
            this.Text = "Game" + nThGame;
            nThGame++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfHorses = int.Parse(txtNumberOfHorses.Text);
            Random random = new Random();
            int startX = 10;
            int startY = 100;
            int no;
            horses = new List<Horse>();
            for (int i = 0; i < numberOfHorses; i++)
            {
                int speedX = random.Next(MIN_SPEED, MAX_SPEED);
                int tickInterval = random.Next(MIN_TICK_INT, MAX_TICK_INT);

                Horse horse = new Horse(pnlFinishLine, speedX, tickInterval);
                horse.Left = startX;
                horse.Top = startY;
                horse.Height = 50;
                horse.Width = 40;
                no = i + 1;
                horse.Text = "No: " + no;
                horse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                horse.Image = Resources.horse;
                horse.HorseTimer.Enabled = true;
                horse.Stopwatch.Start();
                horses.Add(horse);
                startY += 45;
                this.Controls.Add(horse);
            }
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            string message = "";
            string title = this.Text + " Race Results";
            if (horses == null)
            {
                MessageBox.Show("Please enter number of horses");
                return;
            }
            foreach (var i in horses)
            {
                if ((i.FinishedReport != null) && (i.FinishedReport.Length > 0))
                {
                    message += i.FinishedReport + "\n";
                }
            }
            MessageBox.Show(message, title);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            HorseRace horseRace = new HorseRace();
            horseRace.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
