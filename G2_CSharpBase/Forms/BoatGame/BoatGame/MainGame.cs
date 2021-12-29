using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatGame
{
    public partial class form : Form
    {
        int colorCount;
        int yGap;
        List<Boat> boats = new List<Boat>();

        List<Color> colors = new List<Color>()
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet
        };
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            dgvColors.ColumnCount = 1;
            dgvColors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvColors.Columns[0].Name = "Colors";
            foreach (var i in colors)
            {
                dgvColors.Rows.Add(i);
                cbbRemoveColors.Items.Add(i);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"../../../");
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string fileName = Path.Combine(dir, @"images\b1.png");

            colorCount = int.Parse(txtColorSequence.Text);
            for (int i = 0; i < colorCount; i++)
            {
                Random random = new Random();
                int speed = random.Next(40, 80);

                Boat boat = new Boat();
                boat.Left = 20;
                boat.Top = (20 * i) + yGap;
                boat.BackColor = colors[i];
                boat.Height = 20;
                boat.Width = 50;
                boat.Water = grbWater;
                boats.Add(boat);

                grbWater.Controls.Add(boat);
                yGap += 10;
                boat.BoatTimer = new Timer();
                boat.BoatTimer.Enabled = true;
                boat.BoatTimer.Interval = speed;
                boat.BoatTimer.Start();
                boat.BoatTimer.Tick += boat.Timer_Tick;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = boats.Count; 
            Random random = new Random();
            int speed = random.Next(40, 80);
            
            Boat boat = new Boat();
            boat.Left = 20;
            boat.Top = (20 * i) + yGap;
            boat.BackColor = colors[random.Next(colors.Count)];
            boat.Height = 20;
            boat.Width = 50;
            boat.Water = grbWater;
            boats.Add(boat);

            grbWater.Controls.Add(boat);
            yGap += 10;
            boat.BoatTimer = new Timer();
            boat.BoatTimer.Enabled = true;
            boat.BoatTimer.Interval = speed;
            boat.BoatTimer.Start();
            boat.BoatTimer.Tick += boat.Timer_Tick;            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = int.Parse(txtDelete.Text);
                grbWater.Controls.RemoveAt(idx);
                boats.RemoveAt(idx);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter boat number");
            }
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            string newColor = txtColorSequence.Text;
            colors.Add(Color.Lavender);
            dgvColors.Rows.Add(Color.Lavender);
            cbbRemoveColors.Items.Add(Color.Lavender);
            txtColorSequence.Text = colors.Count.ToString();
        }

        private void btnRemoveColor_Click(object sender, EventArgs e)
        {
            int idx = cbbRemoveColors.SelectedIndex;
            colors.RemoveAt(idx);
            dgvColors.Rows.RemoveAt(idx);
            cbbRemoveColors.Items.RemoveAt(idx);
            txtColorSequence.Text = colors.Count.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Custom Methods

        #endregion

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTest.Text = "enter";
            }
            if (e.KeyCode == Keys.Left)
            {
                foreach (var i in boats)
                {
                    i.GoLeft = true;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                foreach (var i in boats)
                {
                    i.GoLeft = false;
                }
            }
        }
    }
}
