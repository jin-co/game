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
    at a time to complete a straight line first to win
     */
    public partial class TicTacToe : Form
    {
        const int MAXTURN = 9;
        int index = 0;
        bool gameOver = false;

        PictureBox[] pictureBoxes = new PictureBox[MAXTURN];

        // when the app is initialized, puts picture boxes to an array
        public TicTacToe()
        {
            InitializeComponent();
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;

            foreach (var i in pictureBoxes)
            {
                i.Visible = false;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picClicked = sender as PictureBox;

            if (index < MAXTURN)
            {
                // puts image only when the pictureBox is empty
                if (picClicked.Image == null)
                {
                    if (index % 2 == 0)
                    {
                        picClicked.Image = Resource.x;
                        picClicked.Tag = 'x';
                        index++;
                        CheckWinner('x', picClicked);
                        if (gameOver)
                        {
                            lblText.Text = "X Wins";
                            showMessage();
                        }
                    }
                    else
                    {
                        picClicked.Image = Resource.o;
                        picClicked.Tag = 'o';
                        index++;
                        CheckWinner('o', picClicked);
                        if (gameOver)
                        {
                            lblText.Text = "O Wins";
                            showMessage();
                        }
                    }                    
                }
            }
            else
            {
                resetGame();
            }

            if (index == MAXTURN)
            {
                lblText.Text = "Tie";
                showMessage();
            }
        }

        // shows a message and sets the screen either to the main screen or 
        // initial play screen based on the answer
        private void showMessage()
        {
            DialogResult finished = MessageBox.Show("Do you want to play again?", "Finished",
                                MessageBoxButtons.YesNo);
            if (finished == DialogResult.Yes)
            {
                resetGame();
            }
            else
            {
                resetGame();
                goToMain();
            }
        }

        // shows the main screen with everything set back to when the
        // game first started with a new background image
        private void goToMain()
        {
            foreach (var i in pictureBoxes)
            {
                i.Visible = false;
            }
            btnStart.Visible = true;
            this.BackgroundImage = Resource.bg_board3;
            lblText.Text = "Tic Tac Toe";
            lblText.BackColor = Color.Black;
            lblText.ForeColor = Color.White;
        }

        // resets index to 0 and delete all the images to start over
        private void resetGame()
        {
            index = 0;
            gameOver = false;
            lblText.Text = "In Play";
            foreach (var i in pictureBoxes)
            {
                i.Image = null;
                i.Tag = "";
            }
        }

        // checks if there is a winner after each turn
        // if there is, sete the 'gameOver' to true 
        private void CheckWinner(char choice, PictureBox icon)
        {
            int index = Array.IndexOf(pictureBoxes, icon);
            switch (index)
            {
                case 0:
                    if (pictureBoxes[1].Tag != null && pictureBoxes[1].Tag.Equals(choice))
                        if (pictureBoxes[2].Tag != null && pictureBoxes[2].Tag.Equals(choice))
                            gameOver = true;
                    
                    if (pictureBoxes[3].Tag != null && pictureBoxes[3].Tag.Equals(choice))
                        if (pictureBoxes[6].Tag != null && pictureBoxes[6].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                        if (pictureBoxes[8].Tag != null && pictureBoxes[8].Tag.Equals(choice))
                            gameOver = true;
                    break;
                
                case 1:
                    if (pictureBoxes[0].Tag != null && pictureBoxes[0].Tag.Equals(choice))
                        if (pictureBoxes[2].Tag != null && pictureBoxes[2].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                        if (pictureBoxes[7].Tag != null && pictureBoxes[7].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 2:
                    if (pictureBoxes[1].Tag != null && pictureBoxes[1].Tag.Equals(choice))
                        if (pictureBoxes[0].Tag != null && pictureBoxes[0].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[5].Tag != null && pictureBoxes[5].Tag.Equals(choice))
                        if (pictureBoxes[8].Tag != null && pictureBoxes[8].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                        if (pictureBoxes[6].Tag != null && pictureBoxes[6].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 3:
                    if (pictureBoxes[0].Tag != null && pictureBoxes[0].Tag.Equals(choice))
                        if (pictureBoxes[6].Tag != null && pictureBoxes[6].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                        if (pictureBoxes[5].Tag != null && pictureBoxes[5].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 4:
                    if (pictureBoxes[1].Tag != null && pictureBoxes[1].Tag.Equals(choice))
                        if (pictureBoxes[7].Tag != null && pictureBoxes[7].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[3].Tag != null && pictureBoxes[3].Tag.Equals(choice))
                        if (pictureBoxes[5].Tag != null && pictureBoxes[5].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[0].Tag != null && pictureBoxes[0].Tag.Equals(choice))
                        if (pictureBoxes[8].Tag != null && pictureBoxes[8].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[2].Tag != null && pictureBoxes[2].Tag.Equals(choice))
                        if (pictureBoxes[6].Tag != null && pictureBoxes[6].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 5:                  
                    if (pictureBoxes[3].Tag != null && pictureBoxes[3].Tag.Equals(choice))
                        if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[2].Tag != null && pictureBoxes[2].Tag.Equals(choice))
                        if (pictureBoxes[8].Tag != null && pictureBoxes[8].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 6:                    
                    if (pictureBoxes[3].Tag != null && pictureBoxes[3].Tag.Equals(choice))
                        if (pictureBoxes[0].Tag != null && pictureBoxes[0].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[7].Tag != null && pictureBoxes[7].Tag.Equals(choice))
                        if (pictureBoxes[8].Tag != null && pictureBoxes[8].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[2].Tag != null && pictureBoxes[2].Tag.Equals(choice))
                        if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 7:
                    if (pictureBoxes[1].Tag != null && pictureBoxes[1].Tag.Equals(choice))
                        if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[6].Tag != null && pictureBoxes[6].Tag.Equals(choice))
                        if (pictureBoxes[8].Tag != null && pictureBoxes[8].Tag.Equals(choice))
                            gameOver = true;
                    break;

                case 8:
                    if (pictureBoxes[5].Tag != null && pictureBoxes[5].Tag.Equals(choice))
                        if (pictureBoxes[2].Tag != null && pictureBoxes[2].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[7].Tag != null && pictureBoxes[7].Tag.Equals(choice))
                        if (pictureBoxes[6].Tag != null && pictureBoxes[6].Tag.Equals(choice))
                            gameOver = true;

                    if (pictureBoxes[0].Tag != null && pictureBoxes[0].Tag.Equals(choice))
                        if (pictureBoxes[4].Tag != null && pictureBoxes[4].Tag.Equals(choice))
                            gameOver = true;
                    break;
            }
        }

        // when clicked shows the game screen and changes
        // the colors and text of the title
        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var i in pictureBoxes)
            {
                i.Visible = true;
            }
            btnStart.Visible = false;
            this.BackgroundImage = Resource.bg_board2;
            lblText.Text = "In Play";
            lblText.BackColor = Color.White;
            lblText.ForeColor = Color.Black;
        }
    }
}
