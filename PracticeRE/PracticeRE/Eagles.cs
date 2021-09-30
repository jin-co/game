using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeRE
{
    // Eagle class
    class Eagles
    {
        #region Constructors
        public Eagles() {}
        #endregion

        #region Properties
        public PictureBox[] EaglesPic { get; set; }
        public Point[] StartingPoint { get; set; }
        public bool GoLeft { get; set; }
        #endregion

        #region Fields
        private int xSpeed;

        Random random = new Random();
        #endregion

        #region Methods
        public void UpdatePosition()
        {
            for (int i = 0; i < EaglesPic.Length; i++)
            {
                // vertical movement
                xSpeed = random.Next(20, 50);
                EaglesPic[i].Top += xSpeed;

                // horizontal movement
                if (GoLeft)
                {
                    if (EaglesPic[i].Left <= 0)
                    {
                        EaglesPic[i].Left -= 0;
                    }
                    else
                    {
                        EaglesPic[i].Left -= 10;
                    }
                }
                if (!GoLeft)
                {
                    if (EaglesPic[i].Right + 19 >= EaglesPic[i].Parent.Width)
                    {
                        EaglesPic[i].Left += 0;
                    }
                    else
                    {
                        EaglesPic[i].Left += 10;
                    }
                }
            }
        }

        // resets eagle to the starting position
        public void resetEaglePosition()
        {
            for (int i = 0; i < EaglesPic.Length; i++)
            {
                EaglesPic[i].Location = StartingPoint[i];
            }
        }
        #endregion
    }
}
