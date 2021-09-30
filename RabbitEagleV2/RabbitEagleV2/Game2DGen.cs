using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagleV2
{
    // generating game component
    class Game2DGen
    {
        protected Control parent;
        protected int width, height;
        protected Color backColor;

        private Color defaultColor;
        public int gapX, gapY;
        public int startX, startY;

        public Game2DGen() {}

        public Game2DGen(Control parent, int width, int height)
        {
            this.parent = parent;
            this.width = width;
            this.height = height;
        }

        public PictureBox[,] GeneratePicBoxes(int rows, int cols)
        {
            int x = startX, y = startY;
            int number = 0;
            PictureBox[,] pictureBoxes = new PictureBox[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox p = new PictureBox();
                    p.Left = x;
                    p.Top = y;
                    p.Width = width;
                    p.Height = height;
                }
            }

        }
    }
}
