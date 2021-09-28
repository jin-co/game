using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    class Horse : Button
    {
        private Control parent;
        private int speedX;
        private Panel finishLine;
        private bool isFinished;

        public Timer horseTimer;
        public string finishedReport;
        public Stopwatch stopWatch;

        public Horse() {}

        public Horse(int speedX, Panel finishLine, int tickInterval)
        {
            this.speedX = speedX;
            this.finishLine = finishLine;

            horseTimer = new Timer();
            horseTimer.Interval = tickInterval;
            horseTimer.Enabled = false;
            horseTimer.Tick += HorseTimerTick;
        }

        private void HorseTimerTick(object sender, EventArgs e)
        {
            this.Left += speedX;
            if (!isFinished)
            {
                if (this.Left + this.Width > finishLine.Left)
                {
                    isFinished = true;
                    
                    // stop the timer
                    stopWatch.Stop();
                    horseTimer.Stop();

                    // generate the record
                    finishedReport = this.Text + $"Race Time: {stopWatch.ElapsedMilliseconds}ms";
                }
            }
        }
    }
}
