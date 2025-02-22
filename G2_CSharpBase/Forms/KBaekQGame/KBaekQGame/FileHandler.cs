﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* FileHandling class that handles calls(save, load, ...)
     * related to the files
     */
    class FileHandler
    {
        #region Fields
        Game game = new Game();
        #endregion

        #region Methods
        /// <summary>
        /// Saves file to a chosen path with a message showing
        /// if the save was successful or not
        /// </summary>
        public static void SaveFile()
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
                sw.WriteLine(Game.Rows);
                sw.WriteLine(Game.Cols);
                for (int row = 0; row < Game.Rows; row++)
                {
                    for (int col = 0; col < Game.Cols; col++)
                    {
                        sw.WriteLine(row.ToString());
                        sw.WriteLine(col.ToString());
                        if (Game.Cubes[row, col].Tag != null)
                        {
                            sw.WriteLine(Game.Cubes[row, col].Tag.ToString());
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                    }
                }
                sw.Dispose();
                GameMessage.ShowMessage(0, CalculateResult());
            }
            else
            {
                GameMessage.ShowMessage(2, "No File Added");
            }
        }

        /// <summary>
        /// Loads a file that has been saved on the design form
        /// a message showing if the save was successful or not
        /// </summary>
        public static void LoadFile()
        {
            string result = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Maze Game Data (*.txt)|*.txt";
            string filePath = @"c:/";
            ofd.InitialDirectory = filePath;
            ofd.Title = "Load";

            if (ofd.ShowDialog() == DialogResult.OK)
            {                                
                StreamReader sr = new StreamReader(ofd.FileName);
                while (!sr.EndOfStream)
                {
                    result += sr.ReadLine();
                }
                sr.Dispose();

                Game.LoadString = result;
                Game.Rows = int.Parse(Game.LoadString[0].ToString());
                Game.Cols = int.Parse(Game.LoadString[1].ToString());
                Game.Cubes = new Cube[Game.Rows, Game.Cols];
            }
            else
            {
                GameMessage.ShowMessage(2, "Loading Failed");
            }

            GameScore.BoxCount = 0;
            GameScore.MovementCount = 0;
            GameScore.ChangeGameStatus(false);
        }

        /// <summary>
        /// Calculates the total amount of each items chosen
        /// returns a message with the calculated value
        /// </summary>
        /// <returns></returns>
        private static string CalculateResult()
        {
            int wallCount = 0, doorCount = 0, boxCount = 0;
            foreach (var i in Game.Cubes)
            {
                if (i.Tag != null)
                {
                    int tag = int.Parse(i.Tag.ToString());
                    if (tag == 1)
                    {
                        wallCount++;
                    }

                    if (tag == 2 || tag == 3)
                    {
                        doorCount++;
                    }

                    if (tag == 4 || tag == 5)
                    {
                        boxCount++;
                    }
                }
            }

            return $"File Saved Successfully\n" +
                    $"Walls: {wallCount} \nDoors: {doorCount} \nBoxes: {boxCount}";
        }
        #endregion
    }
}
