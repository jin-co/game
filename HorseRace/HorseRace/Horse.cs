using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    // horse class 
    class Horse : Button
    {
        #region Constructors
        public Horse() {}
        #endregion

        #region Properties
        public Timer HorseTime { get; set; }
        public Stopwatch Stopwatch { get; set; }
        public int Speed { get; set; }
        public Panel FinishLine { get; set; }
        public string Record { get; set; }
        public bool isFinished { get; set; }
        #endregion

        #region Fields
        #endregion

        #region Methods
        public void Timer_Tick(object sender, EventArgs e)
        {
            if (!(this.Right >= FinishLine.Left))
            {
                this.Left += Speed;
                isFinished = true;
                Stopwatch.Stop();
                Record = Stopwatch.ElapsedMilliseconds.ToString();
            }
        }
        #endregion

    }
}
