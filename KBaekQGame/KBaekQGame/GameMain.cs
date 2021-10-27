using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Author: Kwangjin Baek
     * Date: 2021. Nov. 1.
     * Description: Game application consisting of a number of colored doors 
     * and corresponding number of colored boxes for users to create and 
     * play to remove all the blocks by matching each pieces that have the same
     * colors
     */

    public partial class GameMain : Form
    {
        public GameMain()
        {
            InitializeComponent();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            GameDesign gameDesign = new GameDesign();
            gameDesign.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
