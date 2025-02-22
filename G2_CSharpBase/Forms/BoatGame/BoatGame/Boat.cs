﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatGame
{
    class Boat : Label
    {
        public Color BackgroundColor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Timer BoatTimer { get; set; }
        public bool GoLeft { get; set; }
        public GroupBox Water { get; set; }


        public void Timer_Tick(object sender, EventArgs e)
        {
            if (GoLeft)
            {
                if (!(this.Left <= (Water.Width - Water.Width)))
                {
                    this.Left -= 12;
                }
                else
                {
                    GoLeft = false;
                }
            }
            else
            {
                if (!(this.Right >= Water.Width))
                {
                    this.Left += 12;
                }
                else
                {
                    GoLeft = true;
                }
            }
        }
    }
}
