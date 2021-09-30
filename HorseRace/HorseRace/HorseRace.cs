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

namespace HorseRace
{
    public partial class HorseRace : Form
    {
        // without the static it will always be 1
        private static int nThGame = 1; // this will increment the number for each game
        private List<Horse> horses;
        private const int MIN_SPEED = 5;
        private const int MAX_SPEED = 20;
        private const int MIN_TICK = 200;
        private const int MAX_TICK = 600;

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
            int startY = 150;
            int no;
            horses = new List<Horse>();

            for (int i = 0; i < numberOfHorses; i++)
            {
                int speedX = random.Next(MIN_SPEED, MAX_SPEED);
                int tickInterval = random.Next(MIN_TICK, MAX_TICK);

                Horse horse = new Horse(speedX, pnlFinishiLine, tickInterval);
                horse.Left = startX;
                horse.Top = startY;
                horse.Width = 56;
                horse.Height = 42;
                no = i + 1;
                horse.Text = "Horse No: " + no;
                horse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                horse.Image = Resources.horse;
                horse.horseTimer.Enabled = true;
                horse.stopWatch = new Stopwatch();
                horse.stopWatch.Start();
                horses.Add(horse);
                startY += 45; // 42 + 3 gap
                this.Controls.Add(horse);
            }
        }

        private void HorseRace_Load(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string message = "";
            string title = this.Text + " Race Results";
            if (horses == null)
            {
                MessageBox.Show("Please enter number of horses then start the game first", "Tips");
                return;
            }

            foreach (Horse i in horses)
            {
                if ((i.finishedReport != null) && (i.finishedReport.Length > 0))
                {
                    message += i.finishedReport + "\n";
                }
            }

            MessageBox.Show(message, title);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            HorseRace hourseRaceGame = new HorseRace();
            hourseRaceGame .Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
