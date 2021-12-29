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
    public partial class Main : Form
    {
        Horse horse;
        List<Horse> horses = new List<Horse>();
        string message = "";
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberOfHorses = int.Parse(txtNumberOfHorses.Text);
            for (int i = 0; i < numberOfHorses; i++)
            {
                Random random = new Random();
                int speed = random.Next(40, 80);
                horse = new Horse();
                horse.Width = 50;
                horse.Height = 50;
                horse.Image = Resources.horse;
                horse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                horse.Top = 20 + (50 * i);
                horse.Left = 50;
                horse.FinishLine = pnlFinishLine;
                horse.HorseTime = new Timer();
                horse.HorseTime.Enabled = true;
                horse.HorseTime.Interval = speed;
                horse.Stopwatch = new Stopwatch();
                horse.Stopwatch.Start();
                horses.Add(horse);
                pnlGround.Controls.Add(horse);
                horse.HorseTime.Tick += horse.Timer_Tick;
            }            
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            foreach (var i in horses)
            {
                if (i.isFinished)
                {
                    message += i.Record + "\n";
                }
            }
            MessageBox.Show(message);
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
