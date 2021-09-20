using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekAssignment1
{
    /*
    Description: 
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

        public Button StartButton { get; set; }
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
        /// if there is, sete the 'gameOver' to true  
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="icon"></param>
        public void CheckWinner(char choice, PictureBox icon)
        {
            int index = Array.IndexOf(PictureBoxes, icon);
            switch (index)
            {
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

                case 1:
                    if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                        if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                        if (PictureBoxes[7].Tag != null && PictureBoxes[7].Tag.Equals(choice))
                            GameOver = true;
                    break;

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

                case 3:
                    if (PictureBoxes[0].Tag != null && PictureBoxes[0].Tag.Equals(choice))
                        if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                        if (PictureBoxes[5].Tag != null && PictureBoxes[5].Tag.Equals(choice))
                            GameOver = true;
                    break;

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

                case 5:
                    if (PictureBoxes[3].Tag != null && PictureBoxes[3].Tag.Equals(choice))
                        if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[2].Tag != null && PictureBoxes[2].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;
                    break;

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

                case 7:
                    if (PictureBoxes[1].Tag != null && PictureBoxes[1].Tag.Equals(choice))
                        if (PictureBoxes[4].Tag != null && PictureBoxes[4].Tag.Equals(choice))
                            GameOver = true;

                    if (PictureBoxes[6].Tag != null && PictureBoxes[6].Tag.Equals(choice))
                        if (PictureBoxes[8].Tag != null && PictureBoxes[8].Tag.Equals(choice))
                            GameOver = true;
                    break;

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

        // shows a message and sets the screen either to the main screen or 
        // initial play screen based on the answer
        public void ShowFinishMessage()
        {
            DialogResult finished = MessageBox.Show("Do you want to play again?", "Finished",
                                MessageBoxButtons.YesNo);
            if (finished == DialogResult.Yes)
            {
                ResetGame();
                TitleSign.Text = Game.GetPlayMessage();
            }
            else
            {
                ResetGame();
                TitleSign.Text = Game.GetTitle();
                GoToMain();
            }
        }


        // shows the main screen with everything set back to when the
        // game first started with a new background image
        private void GoToMain()
        {
            foreach (var i in PictureBoxes)
            {
                i.Visible = false;
            }
            StartButton.Visible = true;
            //.BackgroundImage = Resource.bg_board3;
            TitleSign.Text = Game.GetTitle();
            TitleSign.BackColor = Color.Black;
            TitleSign.ForeColor = Color.White;
        }
        #endregion
    }
}
