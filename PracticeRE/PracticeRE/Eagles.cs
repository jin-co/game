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
        #endregion

        #region Methods
        public void UpdatePosition()
        {
            for (int i = 0; i <= EaglesPic.Length; i++)
            {
                EaglesPic[i].Top += 30;
            }
        }
        #endregion
    }
}
