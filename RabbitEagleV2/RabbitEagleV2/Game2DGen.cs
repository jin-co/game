using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagleV2
{
    // player's super class
    // generating game component
    abstract class Game2DGen
    {
        protected Control parent;
        protected int width, height;
        protected Color backColor = default;

        private Color defaultColor = Color.White;
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

            // generates rows and columns of the picture boxes and set properties
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    PictureBox p = new PictureBox();
                    p.Left = x;
                    p.Top = y;
                    p.Width = width;
                    p.Height = height;
                    // setting the size of generated picture box
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Name = "pictureBox" + number;
                    p.BackColor = backColor;

                    pictureBoxes[row, col] = p;

                    x += width + gapX;
                    number++;
                }
                x = startX;
                y += height + gapX;
            }
            return pictureBoxes;
        }

        public abstract void LoadContent();
        public abstract void Update();
        public abstract void UnloadContent();
    }
}
