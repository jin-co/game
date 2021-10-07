using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame 
{
    public class Game2DGen : PuzzleData
    {
        protected Control parent;

        public Game2DGen (Control parent)
        {
            this.parent = parent;
        }

        public void GenWidget ()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            int width, height;
            DecideWidthHeith(out width, out height);

            if (NotLoaded)
            {
                LoadImage();
            }
        }
    }
}
