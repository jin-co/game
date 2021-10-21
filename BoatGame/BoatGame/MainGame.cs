using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatGame
{
    public partial class form : Form
    {
        int colorCount;
        int yGap;
        List<Boat> boats = new List<Boat>();

        List<Color> colors = new List<Color>()
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet
        };
        public form()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            colorCount = int.Parse(txtColorSequence.Text);
            for (int i = 0; i < colorCount; i++)
            {
                Random random = new Random();
                int speed = random.Next(40, 80);

                Boat boat = new Boat();
                boat.Left = 20;
                boat.Top = (20 * i) + yGap;
                boat.BackColor = colors[i];
                boat.Height = 20;
                boat.Width = 50;
                boats.Add(boat);

                grbWater.Controls.Add(boat);
                yGap += 10;
                boat.BoatTimer = new Timer();
                boat.BoatTimer.Enabled = true;
                boat.BoatTimer.Interval = speed;
                boat.BoatTimer.Start();
                boat.BoatTimer.Tick += boat.Timer_Tick;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = boats.Count; 
            Random random = new Random();
            int speed = random.Next(40, 80);
            
            Boat boat = new Boat();
            boat.Left = 20;
            boat.Top = (20 * i) + yGap;
            boat.BackColor = colors[random.Next(colors.Count)];
            boat.Height = 20;
            boat.Width = 50;
            boat.Water = grbWater;
            boats.Add(boat);

            grbWater.Controls.Add(boat);
            yGap += 10;
            boat.BoatTimer = new Timer();
            boat.BoatTimer.Enabled = true;
            boat.BoatTimer.Interval = speed;
            boat.BoatTimer.Start();
            boat.BoatTimer.Tick += boat.Timer_Tick;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
