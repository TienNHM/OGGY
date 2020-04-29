using System.Drawing;

namespace OGGY.Bground
{
    public abstract class Background
    {
        #region Fileds
        /// <summary>
        /// Hình background 
        /// </summary>
        protected Image background;
        #endregion

        #region Methods
        /// <summary>
        /// Dùng để vẽ lên control 
        /// </summary>
        /// <param name="gp"></param>
        public abstract void Draw(Graphics gp);
        #endregion
    }
}