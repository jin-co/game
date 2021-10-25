using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturePuzzle
{
    class FileIO : PuzzleData
    {
        public void SaveGame()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Puzzle Game Data (*.puzzle)|*.puzzle";
            string filePath = @"c:/5555/puzzle/data";
            sfd.FileName = "PuzzlesGame";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            sfd.InitialDirectory = filePath;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(CurrentLevel);
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        sw.WriteLine(Pieces[row, col].Tag.ToString());
                    }
                }
                sw.Dispose();
            }
        }

        public string[] LoadGame()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Puzzle Game Data (*.puzzle)|*.puzzle";
            string filePath = @"c:/5555/puzzle/data";
            ofd.InitialDirectory = filePath;
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            string[] lines = new string[rows * cols + 1];
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                for (int i = 0; i < rows * cols + 1; i++)
                {
                    lines[i] = sr.ReadLine();
                }
            }
            return lines;
        }
    }
}
