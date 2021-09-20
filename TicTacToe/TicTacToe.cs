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
        // instantiate game class
        Game game = new Game();
        
        // when the app is initialized, puts picture boxes to an array
        public TicTacToe()
        {
            game.PictureBoxes = new PictureBox[game.GetMaxTurn()];
            game.StartButton = btnStart;
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
                        game.CheckWinner('x', picClicked);
                        if (game.GameOver)
                        {
                            lblTitle.Text = "X Wins";
                            game.ShowFinishMessage();
                        }
                    }
                    else
                    {
                        picClicked.Image = Resource.o;
                        picClicked.Tag = 'o';
                        game.GameIndex++;
                        game.CheckWinner('o', picClicked);
                        if (game.GameOver)
                        {
                            lblTitle.Text = "O Wins";
                            game.ShowFinishMessage();
                        }
                    }                    
                }
            }
            else
            {
                game.ResetGame();
            }

            if (game.GameIndex == game.GetMaxTurn())
            {
                lblTitle.Text = "Tie";
                game.ShowFinishMessage();
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
    }
}
