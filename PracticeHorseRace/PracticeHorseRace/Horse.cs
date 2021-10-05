using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHorseRace
{
    /*
     * horse class
     */
    class Horse
    {
        #region Constructors
        public Horse() {}
        #endregion

        #region Properties
        public Button[] Horses { get; set; }
        public int NumberOfHorses { get; set; }
        public int speed { get; set; }
        #endregion

        #region Methods

        public Button[] CreateHorses()
        {
            Horses = new Button[NumberOfHorses];
            for (int i = 0; i < NumberOfHorses; i++)
            {
                Horses[i] = new Button();
                Horses[i].Image = Resources.horse;
                Horses[i].Height = 50;
                Horses[i].Width = 50;
                Horses[i].Top = 150 + (i * 50);
                Horses[i].Left = 50;
                Horses[i].AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Horses[i].AutoSize = true;
            }
            return Horses;
        }

        public void RunHorses()
        {
            Random random = new Random();
            foreach (var i in Horses)
            {
                speed = random.Next(10, 40);
                i.Left += speed;
            }
        }
        #endregion
    }
}
