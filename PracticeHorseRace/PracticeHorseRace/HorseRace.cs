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
    /* horse race game
     * 
     * 
     */
    public partial class HorseRace : Form
    {
        Horse horse = new Horse();
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
            gameTimer.Enabled = true;
            gameTimer.Start();
            gameTimer.Tick += new EventHandler(gameTimer_Tick);

            horse.NumberOfHorses = int.Parse(txtNumberOfHorses.Text);
            horse.createHorses();
            foreach (var i in horse.Horses)
            {
                this.Controls.Add(i);
            }
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
           
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
            second++;
            txtTest.Text = second.ToString();
            foreach (var i in horses)
            {
                i.Left += 10;
            }
        }
    }
}
