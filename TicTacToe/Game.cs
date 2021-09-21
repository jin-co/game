using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekAssignment1
{
    /*
    This class controls the game flow 
    by setting 'GameOver' property's status to true or false
     */
    class Game
    {
        #region Fields
        const int MAX_TURN = 9;

        const string TITLE = "Tic Tac Toe";

        const string PLAY_MESSAGE = "In Play";
        #endregion

        #region Constructors
        // constructors
        public Game() {}
        #endregion

        #region Properties
        // properties
        public PictureBox[] PictureBoxes { get; set; }
        
        public bool GameOver { get; set; }

        public int GameIndex { get; set; }

        public Label TitleSign { get; set; }
        #endregion

        #region Getter, setter methods
        // getter, setter methods
        public int GetMaxTurn()
        {
            return MAX_TURN;
        }

        static public string GetTitle()
        {
            return TITLE;
        }

        static public string GetPlayMessage()
        {
            return PLAY_MESSAGE;
        }
        #endregion

        #region Methods
        /// <summary>
        /// checks if there is a winner after each turn
        /// if there is, sets the 'gameOver' to true  
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="icon"></param>
        public void CheckWinner(char choice, PictureBox icon)
        {
            int index = Array.IndexOf(PictureBoxes, icon);
            switch (index)
            {
                #region Case_0
                case 0:
                    if (PictureBoxes[1].Tag != null && PictureBoxes[1].Tag.Equals(choice))
                        if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[3].Tag != null && PictureBoxes[3].Tag.Equals(choice))
                        if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_1
                case 1:
                    if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                        if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                        if (PictureBoxes[7].Tag != null && PictureBoxes[7].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_2
                case 2:
                    if (PictureBoxes[1].Tag != null && PictureBoxes[1].Tag.Equals(choice))
                        if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[5].Tag != null && PictureBoxes[5].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                        if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_3
                case 3:
                    if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                        if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                        if (PictureBoxes[5].Tag != null && PictureBoxes[5].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_4
                case 4:
                    if (PictureBoxes[1].Tag != null && PictureBoxes[1].Tag.Equals(choice))
                        if (PictureBoxes[7].Tag != null && PictureBoxes[7].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[3].Tag != null && PictureBoxes[3].Tag.Equals(choice))
                        if (PictureBoxes[5].Tag != null && PictureBoxes[5].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                        if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_5
                case 5:
                    if (PictureBoxes[3].Tag != null && PictureBoxes[3].Tag.Equals(choice))
                        if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_6
                case 6:
                    if (PictureBoxes[3].Tag != null && PictureBoxes[3].Tag.Equals(choice))
                        if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[7].Tag != null && PictureBoxes[7].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                        if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_7
                case 7:
                    if (PictureBoxes[1].Tag != null && PictureBoxes[1].Tag.Equals(choice))
                        if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion

                #region Case_8
                case 8:
                    if (PictureBoxes[5].Tag != null && PictureBoxes[5].Tag.Equals(choice))
                        if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[7].Tag != null && PictureBoxes[7].Tag.Equals(choice))
                        if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                        if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                            GameOver = true;
                    break;
                #endregion
            }


        }

        // resets index to 0 and delete all the images to start over
        public void ResetGame()
        {
            GameIndex = 0;
            GameOver = false;
            foreach (var i in PictureBoxes)
            {
                i.Image = null;
                i.Tag = "";
            }
        }
        #endregion
    }
}
