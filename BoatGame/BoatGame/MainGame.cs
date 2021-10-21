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
        Color[] colors = new Color[]
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
                Boat boat = new Boat();
                boat.Left = 20;
                boat.Top = 20;
                boat.BackColor = colors[i];
                boat.Height = 50;
                boat.Width = 50;
                boat.Margin.Bottom = yGap;
                grbWater.Controls.Add(boat);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
