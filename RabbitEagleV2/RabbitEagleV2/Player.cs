using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagleV2
{
    class Player : Game2DGen
    {
        public PictureBox Rabbit;
        public bool goLeft;
        public int speed = 10;

        public Player(Control parent, int width, int height) : base(parent, width, height)
        {
        }

        public override void LoadContent()
        {
            startX = parent.Width / 2;
            startY = parent.Height - 100;
            PictureBox[,] rabbit = GeneratePicBoxes(1, 1);
            rabbit[0, 0].Image = Resources.rabbit;
            Rabbit = rabbit[0, 0];
            parent.Controls.Add(Rabbit);

        }

        public override void UnloadContent()
        {
            parent.Controls.Remove(Rabbit);
        }

        public override void Update()
        {
            if (goLeft)
            {
                Rabbit.Left -= speed;
            }
            else
            {
                Rabbit.Left += speed;
            }

            // boundary check
            if (parent.Left < 0)
            {
                Rabbit.Left += speed;
            }
            if (parent.Left >= parent.Width)
            {
                Rabbit.Left -= speed;
            }
        }
    }
}
