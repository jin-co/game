using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Main : Form
    {
        Horse horse;
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfHorses = int.Parse(txtNumberOfHorses.Text);
            for (int i = 0; i < numberOfHorses; i++)
            {
                horse = new Horse();
                horse.Width = 50;
                horse.Height = 50;
                horse.Image = Resources.horse;
                horse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                horse.Top = 20 + (50 * i);
                horse.Left = 50;
                pnlGround.Controls.Add(horse);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
