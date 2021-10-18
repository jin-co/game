using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicturePuzzle
{
    class FileIO : PuzzleData
    {
        public void SaveGame()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);

        }
    }
}
