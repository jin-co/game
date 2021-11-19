using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBaekQGame
{
    class GameScore
    {
        public static int BoxCount { get; set; }
        public static int MovementCount { get; set; }

        public static int UpdateBoxCount()
        {
            BoxCount = 0;

            foreach (var i in Cube.RedCubes)
            {
                if (i.Image != null)
                {
                    BoxCount++;
                }
            }
            foreach (var i in Cube.GreenCubes)
            {
                if (i.Image != null)
                {
                    BoxCount++;
                }
            }

            return BoxCount;
        }
    }
}
