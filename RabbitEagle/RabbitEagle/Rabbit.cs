using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagle
{
    class Rabbit
    {
        private Control parent;
        public bool goLeft;
        public PictureBox player;
        public Rabbit (Control parent)
        {
            this.parent = parent;
        }

        public void Update(int playerSpeed)
        {
            if (goLeft)
            {
                player.Left -= playerSpeed;
            }
            else
            {
                player.Left += playerSpeed;
            }

            // boundary
            if (player.Left <= 0)
            {
                player.Left += playerSpeed;
            }

            if (player.Left >= parent.Width)
            {
                player.Left -= playerSpeed * 2;
            }
        }
    }
}
