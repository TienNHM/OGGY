using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace OGGY
{
    public abstract class Background : IBackground, IMovable
    {
        #region Fileds
        protected Image background;
        #endregion

        #region Properties

        #endregion

        #region Constructors

        #endregion

        #region Methods

        #endregion

        #region Events
        public abstract void Draw(Graphics gp);
        #endregion
    }
}