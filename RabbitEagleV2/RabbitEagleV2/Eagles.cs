using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagleV2
{
    class Eagles : Game2DGen
    {
        public PictureBox[,] eaglesPic;
        public Eagles(Control parent, int width, int height) : base(parent, width, height)
        {
        }

        public override void LoadContent()
        {
            // setting position
            startX = 10;
            startY = 10;
            gapX = 70;

            // generating artifacts
            eaglesPic = GeneratePicBoxes(1, 10);
            foreach (PictureBox i in eaglesPic)
            {
                i.Image = Resources.eagle;
                parent.Controls.Add(i);
            }
        }

        public override void UnloadContent()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
