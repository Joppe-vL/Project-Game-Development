using Microsoft.Xna.Framework.Graphics;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Game_Development
{
    internal interface IGameObject
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
