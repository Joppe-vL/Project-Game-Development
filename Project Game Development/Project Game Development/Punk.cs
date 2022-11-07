using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Game_Development
{
    internal class Punk : IGameObject
    {
        private Texture2D texture;
        private Rectangle deelRectangle;
        private int SchuifOp_X = 0;

        public Punk(Texture2D texture)
        {
            this.texture = texture;
            deelRectangle = new Rectangle(SchuifOp_X, 0, 48, 48);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(0, 0), deelRectangle, Color.White);
        }

        public void Update()
        {
            SchuifOp_X += 48;
            if (SchuifOp_X > 240)
            {
                SchuifOp_X = 0;
            }
            deelRectangle.X = SchuifOp_X;
        }
    }
}
