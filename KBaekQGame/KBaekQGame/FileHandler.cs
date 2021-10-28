using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* FileHandling class that handles calls 
     * related to the files
     * 
     */
    class FileHandler
    {
        #region Properties
        public int Rows { get; set; }
        public int Cols { get; set; }
        public PictureBox[,] Cubes { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Saves file to a chosen path with a message showing
        /// if the save was successful or not
        /// </summary>
        public void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            
            // settings
            sfd.Filter = "Maze Game Data (*.txt)|*.txt";
            string filePath = @"c:/";
            sfd.InitialDirectory = filePath;
            sfd.Title = "Save";
            sfd.FileName = "maze";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int row = 0; row < Rows; row++)
                {
                    for (int col = 0; col < Cols; col++)
                    {
                        sw.WriteLine(row.ToString());
                        sw.WriteLine(col.ToString());
                        if (Cubes[row, col].Tag != null)
                        {
                            sw.WriteLine(Cubes[row, col].Tag.ToString());
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                    }
                }
                sw.Dispose();
            }
            else
            {
                GameMessage.ShowMessage(2, "No File Added");
            }
        }
        #endregion
    }
}
