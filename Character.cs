using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OGGY
{
    public abstract class Character : ICharacter
    {
        public Image Img;
        public Point Location;

        public abstract void Draw(Graphics gp);

        protected abstract Point GetLocation();
    }
}