using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHorseRace
{
    /*
     * horse class
     */
    class Horse : Button
    {
        #region Properties
        public Timer HorseTimer { get; set; }
        public string FinishedReport { get; set; }
        public Stopwatch Stopwatch { get; set; }
        #endregion

        #region Fields
        private int speedX;
        private Panel finishLine;
        private bool isFinished;
        #endregion

        #region Constructors
        public Horse() {}

        public Horse(Panel finishLine, int speedX, int tickInterval)
        {
            this.finishLine = finishLine;
            this.speedX = speedX;

            Stopwatch = new Stopwatch();
            HorseTimer = new Timer();
            HorseTimer.Interval = tickInterval;
            HorseTimer.Enabled = false;
            HorseTimer.Tick += HorseTimer_Tick;
        }
        #endregion

        #region Methods
        private void HorseTimer_Tick(object sender, EventArgs e)
        {
            this.Left += speedX;
            if (!isFinished)
            {
                if (this.Right > finishLine.Left)
                {
                    isFinished = true;
                    Stopwatch.Stop();
                    HorseTimer.Stop();

                    FinishedReport = this.Text + $"Race Time: {Stopwatch.ElapsedMilliseconds}ms";
                }
            }
        }
        #endregion
    }
}
