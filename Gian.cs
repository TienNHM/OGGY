using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OGGY
{
    public class Gian : Character, IMovable
    {
        #region Fields
        #endregion

        public override void Draw(Graphics gp)
        {
            
        }
        protected override Point GetLocation()
        {
            return new Point();
        }
    }
}