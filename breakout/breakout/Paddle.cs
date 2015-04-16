using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace breakout
{
    public class Paddle : Sprite
    {
        public Paddle(Texture2D texture, Vector2 location, Rectangle screenBounds)
            : base(texture, location, screenBounds)
        {

        }
    }
}
