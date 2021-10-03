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
        public HorseRace()
        {
            InitializeComponent();
        }

        private void HorseRace_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfHorses = int.Parse(txtNumberOfHorses.Text);
            Button[] horses = new Button[numberOfHorses];
            //for (int i = 0; i < numberOfHorses; i++)
            //{
            //    horses[i].Image = Resources.horse;
            //    horses[i].Height = 50;
            //    horses[i].Width = 50;
            //    this.Controls.Add(horses[i]);

            //}

            foreach (var i in horses)
            {
                i.Height = 50;
                i.Width = 50;
                i.Image = Resources.horse;
                i.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
    }
}
