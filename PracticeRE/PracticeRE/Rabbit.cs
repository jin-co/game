using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeRE
{
    // Rabbit class
    class Rabbit
    {
        #region Constructors
        public Rabbit() {}
        #endregion

        #region Properties
        public PictureBox RabbitPic { get; set; }
        public Point StartingPoint { get; set; }
        public bool GoLeft { get; set; }
        public bool GameOver { get; set; }
        #endregion

        #region Methods
        public void UpdatePosition()
        {
            if (!GameOver)
            {
                if (GoLeft)
                {
                    if (RabbitPic.Left <= 0)
                    {
                        RabbitPic.Left -= 0;
                    }
                    else
                    {
                        RabbitPic.Left -= 10;
                    }
                }
                if (!GoLeft)
                {
                    if (RabbitPic.Right + 19 >= RabbitPic.Parent.Width)
                    {
                        RabbitPic.Left += 0;
                    }
                    else
                    {
                        RabbitPic.Left += 10;
                    }
                }
            }
        }

        // resets rabbit to the starting position
        public void resetRabbitPosition()
        {
            RabbitPic.Location = StartingPoint;
        }
        #endregion
    }
}
