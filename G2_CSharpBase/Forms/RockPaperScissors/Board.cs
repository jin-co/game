using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Board : Form
    {
        // for using sound
        private SoundPlayer soundPlayer = null;

        // Define possible turn
        private enum PlayerTurn
        {
            Player1,
            Player2
        }

        // Starting turn
        private PlayerTurn currentTurn = PlayerTurn.Player1;

        // Game status
        private const string PLAYER1_WINS = "Player 1 Won";
        private const string PLAYER2_WINS = "Player 2 Won";
        private const string TIE = "Tie";

        // Images
        private List<Image> images = new List<Image>();

        // Images for referee
        private List<Image> imagesReferee = new List<Image> {
            Resources.referee1,
            Resources.referee2,
            Resources.referee3,
            Resources.referee4,
            Resources.referee5,
            Resources.referee6
            }; 

        // Players pick
        private Image player1Pick;
        private Image player2Pick;

        // Scores
        int score1 = 0;
        int score2 = 0;

        public Board()
        {
            InitializeComponent();
            // Load game images
            LoadGameImages();
        }

        private void box_click(object sender, EventArgs e)
        {
            // enable unified click event
            PictureBox picClicked = sender as PictureBox;
            groupBox.Text = "";
            Random random = new Random();

            int index = random.Next(0, 200) % 3; // 0, 1, 2

            // for easy debugging
            Debug.WriteLine("generated index = " + index);

            if (currentTurn == PlayerTurn.Player1)
            {
                player1Pick = images[index];
            }
            else
            {
                player2Pick = images[index];
                ShowWinner();
            }

            // display image
            picClicked.Image = images[index];

            // allocate the turns
            currentTurn = currentTurn == PlayerTurn.Player1 ? PlayerTurn.Player2 : PlayerTurn.Player1;

            // for sound to be working instantiate then **play
            soundPlayer = new SoundPlayer(Resources.blip);
            soundPlayer.Play();
        }

        private void ShowWinner()
        {
            // just for clarity
            int rock = 0;
            int paper = 1;
            int scissors = 2;

            // player 1
            if (player1Pick == images[rock])
            {
                if (player2Pick == images[rock]) groupBox.Text = TIE;
                if (player2Pick == images[paper])
                {
                    groupBox.Text = PLAYER2_WINS;
                    score2++;
                }
                if (player2Pick == images[scissors])
                {
                    groupBox.Text = PLAYER1_WINS;
                    score1++;
                }
            }
            if (player1Pick == images[paper])
            {
                if (player2Pick == images[paper]) groupBox.Text = TIE;
                if (player2Pick == images[scissors])
                {
                    groupBox.Text = PLAYER2_WINS;
                    score2++;
                }
                if (player2Pick == images[rock])
                {
                    groupBox.Text = PLAYER1_WINS;
                    score1++;
                }
            }
            if (player1Pick == images[scissors])
            {
                if (player2Pick == images[scissors]) groupBox.Text = TIE;
                if (player2Pick == images[rock])
                {
                    groupBox.Text = PLAYER2_WINS;
                    score2++;
                }
                if (player2Pick == images[paper])
                {
                    groupBox.Text = PLAYER1_WINS;
                    score1++;
                }
            }

            txtScore1.Text = score1.ToString();
            txtScore2.Text = score2.ToString();
        }

        private void LoadGameImages()
        {
            images.Add(Resources.rock);
            images.Add(Resources.paper);
            images.Add(Resources.scissors);

            Random random = new Random();
            ptbReferee.Image = imagesReferee[random.Next(7)];
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            PictureBox[] gameImges =
            {
                gamePic1,
                gamePic2,
                gamePic3,
                gamePic4,
                gamePic5,
                gamePic6,
                gamePic7,
                gamePic8,
                gamePic9
            };
            foreach (var j in gameImges)
            {
                j.Image = null;
            }
            //gamePic1.Image = null;
            //gamePic2.Image = null;
            //gamePic3.Image = null;
            //gamePic4.Image = null;
            //gamePic5.Image = null;
            //gamePic6.Image = null;
            //gamePic7.Image = null;
            //gamePic8.Image = null;
            //gamePic9.Image = null;

            player1Pick = null;
            player2Pick = null;

            currentTurn = PlayerTurn.Player1;

            score1 = 0;
            score2 = 0;
            txtScore1.Text = score1.ToString();
            txtScore2.Text = score2.ToString();
        }

        private void btnChangeReferee_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ptbReferee.Image = imagesReferee[random.Next(6)];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
