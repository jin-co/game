using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitEagleV2
{
    public partial class RabbitEagle : Form
    {
        Player player;
        Eagles eagles;
        public RabbitEagle()
        {
            InitializeComponent();
        }

        private void RabbitEagle_Load(object sender, EventArgs e)
        {
            player = new Player(this, 50, 50);
            player.LoadContent();
            eagles = new Eagles(this, 50, 50);
            eagles.LoadContent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
