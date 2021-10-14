using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public class FileHandler : PuzzleData
    {
        public void SaveGame ()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Puzzle Game Data (*.puzzle)|*.puzzle";
            string filePath = @"c:/5555/puzzle/data";
            sfd.FileName = "PuzzleGame";
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
            sfd.InitialDirectory = filePath;
            if (sfd.ShowDialog () == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(CurrentLevel);
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        // OR
                        // sw.WriteLine (row.ToString());
                        // sw.WriteLine (col.ToString());
                        // OR
                        // sw.WriteLine (row.ToString() + "," + col.ToString() + "," + Pieces[row, col].Tag);
                        sw.WriteLine(Pieces[row, col].Tag.ToString());
                    }
                }
                sw.Flush();
                sw.Close();
            }
        }

        public string [] LoadGame ()
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
                for (int n = 0; n < rows*cols+1; n++)
                {
                    lines[n] = sr.ReadLine();
                }
            }
            return lines;
        }
    }
}
