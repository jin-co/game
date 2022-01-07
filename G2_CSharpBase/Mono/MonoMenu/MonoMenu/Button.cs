using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoMenu
{
    /*
     * Inheritance
     * 
     * 
     */
    class Button : SpriteElement
    {
        public bool Pressed { get; set; }
        public Button(ContentManager content) : base(content)
        {
            Pressed = false;
        }

        
    }
}
