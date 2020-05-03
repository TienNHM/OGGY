using System.Drawing;

namespace OGGY.Characters
{
    public abstract class Character
    {
        public Image Img;
        public Point Location;

        public abstract void Draw(Graphics gp);

        /// <summary>
        /// Dùng để xác định vị trí của Character
        /// </summary>
        /// <returns>Location của Character là một Point </returns>
        protected abstract Point GetLocation();
    }
}