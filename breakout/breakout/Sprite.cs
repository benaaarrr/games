using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace breakout
{
    public abstract class Sprite
    {


        public Sprite(Texture2D texture, Vector2 location, Rectangle gameBoundaries)
        {
            this.texture = texture;
            this.location = location;
            this.gameBoundaries = gameBoundaries;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, location, Color.White);               
        }

        Rectangle gameBoundaries { get; set; }
        Vector2 location { get; set; }
        Texture2D texture { get; set; }
    }
}
