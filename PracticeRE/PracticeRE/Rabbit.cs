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

        #endregion

        #region Methods
        public void UpdatePosition()
        {
            if (GoLeft)
            {
                RabbitPic.Left -= 10;
            }
            if (!GoLeft)
            {
                RabbitPic.Left += 10;
            }
        }
        #endregion
    }
}
