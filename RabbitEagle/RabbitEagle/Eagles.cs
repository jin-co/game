using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagle
{
    class Eagles
    {
        private Control parent;
        private const int Y_START = 20;
        private int yMax;
        private int xSpeed, ySpeed;
        private Random random = new Random();


        public bool rabbitStartToMove;
        public bool goLeft;
        public PictureBox[] eagles;
        public Point[] startPosition;
        public bool newGame;

        public Eagles(Control parent)
        {
            this.parent = parent;
            this.yMax = parent.Height - 20;
        }

        public void Update()
        {
            // reset the position of the eagles
            if (newGame)
            {
                for (int i = 0; i < eagles.Length; i++)
                {
                    eagles[i].Location = startPosition[i];
                }
                newGame = false;
            }

            foreach (var i in eagles)
            {
                if (rabbitStartToMove)
                {
                    xSpeed = random.Next(2, 20);

                    if (goLeft)
                    {
                        i.Left -= xSpeed;
                    }
                    else
                    {
                        i.Left += xSpeed;
                    }

                    // boundary
                    if (i.Left <= 0)
                    {
                        i.Left += xSpeed;
                    }
                    if (i.Left >= parent.Width)
                    {
                        i.Left -= xSpeed;
                    }
                }

                // update vertically
                ySpeed = random.Next(3, 30);

                if (i.Top < yMax)
                {
                    i.Top += ySpeed;
                }
                else
                {
                    i.Top = Y_START;
                }
            }
        }
    }
}
