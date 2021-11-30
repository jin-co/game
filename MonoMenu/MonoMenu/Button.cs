using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoMenu
{
    class Button : SpriteElements
    {
        public bool Pressed { get; set; }
        public Button(ContentManager content) : base(content)
        {
            Pressed = false;
        }

        public override void Update()
        {
            MouseState mouseState = Mouse.GetState();
            BoundingBox = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
            bool clicked = (mouseState.LeftButton == ButtonState.Pressed) ||
                (mouseState.RightButton == ButtonState.Pressed) ||
                (mouseState.MiddleButton == ButtonState.Pressed);

            if (clicked)
            {
                if (BoundingBox.Contains(mouseState.Position.ToVector2()))
                {
                    Pressed = true;
                }
            }
        }

        public override void Reset()
        {
            base.Reset();
            Pressed = false;
        }
    }
}
