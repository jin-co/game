using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoCarRace
{
    class GameElement
    {
        private Random random = new Random();
        private int carCount;
        private Texture2D[] carTexture;
        private string[] spriteName;
        private SpriteFont gameFont;

        private int startX = 0;
        private int[] startY = 
        {
            GameMain.screenHeight - 65,  
            GameMain.screenHeight - 91,  
            GameMain.screenHeight - 117
        };

        private Vector2[] positions =
        {
            Vector2.Zero,
            Vector2.Zero,
            Vector2.Zero
        };

        private bool[] windstates = {false, false, false};

        private bool[] reported = {false, false, false};

        private string[] carReports = { "Red Car:", "White Car:", "Yellow Car:" };

        private int winnerCount = 0;
    }
}
