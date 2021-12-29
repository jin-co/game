using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekAssignment1
{
    /*
    Author: Kwangjin Baek
    Date: 2021. Sep. 20.
    Description: 
    A game application that two players can chose a box
    in turn to complete a straight line first to win
     */
    public partial class TicTacToe : Form
    {
        // instantiate game class
        Game game = new Game();

        // when the app is initialized, puts picture boxes to an array
        // and hides the boxes from the screen
        public TicTacToe()
        {
            game.PictureBoxes = new PictureBox[game.GetMaxTurn()];
            InitializeComponent();

            game.PictureBoxes[0] = pictureBox1;
            game.PictureBoxes[1] = pictureBox2;
            game.PictureBoxes[2] = pictureBox3;
            game.PictureBoxes[3] = pictureBox4;
            game.PictureBoxes[4] = pictureBox5;
            game.PictureBoxes[5] = pictureBox6;
            game.PictureBoxes[6] = pictureBox7;
            game.PictureBoxes[7] = pictureBox8;
            game.PictureBoxes[8] = pictureBox9;

            foreach (var i in game.PictureBoxes)
            {
                i.Visible = false;
            }
        }

        // catches click event on picture boxes and
        // allows user to choose
        // either until the game index
        // reaches the maximum index(which is 9)
        // or there is a winner
        // then shows message and go back to main or
        // let the user play another game based on the
        // user's choice
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picClicked = sender as PictureBox;
            game.GameOver = false;

            if (game.GameIndex < game.GetMaxTurn())
            {
                // puts image only when the pictureBox is empty
                if (picClicked.Image == null)
                {
                    if (game.GameIndex % 2 == 0)
                    {
                        picClicked.Image = Resource.x;
                        picClicked.Tag = 'x';
                        game.GameIndex++;
                        try
                        {
                            game.CheckWinner('x', picClicked);
                        }
                        catch (Exception error)
                        {
                            lblTitle.Text += error.Message;
                        }

                        if (game.GameOver)
                        {
                            lblTitle.Text = "X Wins";
                            ShowFinishMessage();
                        }
                    }
                    else
                    {
                        picClicked.Image = Resource.o;
                        picClicked.Tag = 'o';
                        game.GameIndex++;
                        try
                        {
                            game.CheckWinner('o', picClicked);
                        }
                        catch (Exception error)
                        {
                            lblTitle.Text += error.Message;
                        }

                        if (game.GameOver)
                        {
                            lblTitle.Text = "O Wins";
                            ShowFinishMessage();
                        }
                    }
                }
            }
            else
            {
                try
                {
                    game.ResetGame();
                }
                catch (Exception error)
                {
                    lblTitle.Text += error.Message;
                }
            }

            if (game.GameIndex == game.GetMaxTurn())
            {
                lblTitle.Text = "Tie";
                ShowFinishMessage();
            }
        }

        // when clicked shows the game screen and changes
        // the colors and text of the title
        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var i in game.PictureBoxes)
            {
                i.Visible = true;
            }
            btnStart.Visible = false;
            this.BackgroundImage = Resource.bg_board2;
            lblTitle.Text = "In Play";
            lblTitle.BackColor = Color.White;
            lblTitle.ForeColor = Color.Black;
        }

        #region Custom Methods
        // shows a message and sets the screen either to the main screen or 
        // initial play screen based on the answer
        private void ShowFinishMessage()
        {
            DialogResult finished = MessageBox.Show("Do you want to play again?", "Finished",
                                MessageBoxButtons.YesNo);
            if (finished == DialogResult.Yes)
            {
                try
                {
                    game.ResetGame();
                }
                catch (Exception error)
                {
                    lblTitle.Text += error.Message;
                }

                lblTitle.Text = Game.GetPlayMessage();
            }
            else
            {
                try
                {
                    game.ResetGame();
                }
                catch (Exception error)
                {
                    lblTitle.Text += error.Message;
                }

                lblTitle.Text = Game.GetTitle();
                GoToMain();
            }
        }

        // shows the main screen with everything set back to when the
        // game first started with a new background image
        private void GoToMain()
        {
            foreach (var i in game.PictureBoxes)
            {
                i.Visible = false;
            }
            btnStart.Visible = true;
            this.BackgroundImage = Resource.bg_board3;
            lblTitle.Text = Game.GetTitle();
            lblTitle.BackColor = Color.Black;
            lblTitle.ForeColor = Color.White;
        }
        #endregion
    }
}
