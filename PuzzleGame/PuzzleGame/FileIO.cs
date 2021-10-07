using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    class FileIO : PuzzleData
    {
        public void SaveGame()
        {
            int rows, cols;
            DecideRowsCols(out rows, out cols);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Puzzle  Game Data (*.puzzle)|*.puzzle";
            string filePath = @"c:/5555/puzzle/data";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            sfd.InitialDirectory = filePath;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(sfd.FileName);
                streamWriter.WriteLine(currentLevel);
                for (int row = 0; row < cols; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        //streamWriter.WriteLine(pieces[row, col]);
                        streamWriter.WriteLine(pieces[row, col].Tag.ToString());
                    }
                }
            }
        }

        public void LoadGame()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Puzzle  Game Data (*.puzzle)|*.puzzle";
            string filePath = @"c:/5555/puzzle/data";
            ofd.InitialDirectory = filePath;
            int rows, cols;
            DecideRowsCols(out rows, out cols);
            string[] lines = new string[rows * cols + 1];
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                for (int i = 0; i < rows * cols + 1; i++)
                {
                    lines[i] = streamReader.ReadLine();
                }
                streamReader.Dispose();
            }
        }
    }
}
