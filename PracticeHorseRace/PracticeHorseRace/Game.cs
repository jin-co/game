using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHorseRace
{
    /*
     * game class
     */
    class Game
    {
        #region Constructors
        public Game() {}

        #endregion

        #region Properties
        public Panel FinishLine { get; set; }
        public Timer GameTimer { get; set; }
        public bool IsFinished { get; set; }
        #endregion

        #region Methods
        #endregion

    }
}
