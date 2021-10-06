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
        Horse horse = new Horse();
        Game game = new Game();
        int second = 0;
        Stopwatch stopWatch = new Stopwatch();
        public HorseRace()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            gameTimer.Start();
            gameTimer.Tick += new EventHandler(gameTimer_Tick);

            // creating horses
            horse.NumberOfHorses = int.Parse(txtNumberOfHorses.Text);
            horse.CreateHorses();
            foreach (var i in horse.Horses)
            {
                this.Controls.Add(i);
            }

            // game
            game.FinishLine = pnlFinishLine;
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            HorseRace horseRace = new HorseRace();
            horseRace.Show();
            stopWatch.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Interval = 100;
            second++;
            //txtTest.Text = second.ToString();

            if (!horse.IsFinished)
            {
                horse.RunHorses();
                foreach (var i in horse.Horses)
                {
                    if (i.Right > game.FinishLine.Left)
                    {
                        //txtTest.Text = $"{i.Right}\t{game.FinishLine.Left}";
                        stopWatch.Stop();
                        txtTest.Text += "\t" + stopWatch.ElapsedMilliseconds;
                        horse.IsFinished = true;
                    }
                }

                //if (this.Left + this.Width > game.FinishLine.Left)
                //{
                //    txtTest.Text = $"{this.Left}\t{this.Right}\t{game.FinishLine.Left}";
                //    horse.IsFinished = true;
                //}
            }
        }
    }
}
