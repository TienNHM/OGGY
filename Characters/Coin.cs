using System;
using System.Drawing;
using System.Reflection;

namespace OGGY.Characters
{
    public class Coin : Character
    {
        public static int iWidth = 32;
        public static int iHeight = 45;

        /// <summary>
        /// True nếu coin chưa được earn
        /// </summary>
        public bool bVisible { get; set; } = true;

        /// <summary>
        /// Dùng để xác định index của coin trong danh sách 
        /// </summary>
        private int index { get; }
        private Random random = new Random();

        public Coin(int index)
        {
            this.index = index;
            Assembly assembly = Assembly.GetExecutingAssembly();
            switch (index)
            {
                case 0: Img = Properties.Resources.coin0;           break;
                case 1: Img = Properties.Resources.coin1;           break;
                case 2: Img = Properties.Resources.coin2;           break;
                case 3: Img = Properties.Resources.coin3;           break;
                case 4: Img = Properties.Resources.coin4;           break;
                case 5: Img = Properties.Resources.coin5;           break;
                case 6: Img = Properties.Resources.coin6;           break;
                case 7: Img = Properties.Resources.hud_powerbtn;    break;
                case 8: Img = Properties.Resources.heart_full; ;    break;
            }
            Location = GetLocation();
        }

        /// <summary>
        /// Dùng để xác định Location của từng coin dựa theo index 
        /// </summary>
        /// <returns>Location của coin là một Point </returns>
        protected override Point GetLocation()
        {
            if (index >= 7)
                return new Point(frmMain.iWidth + index * 150, random.Next(250, Oggy.iTop) - (index - 6) * 50);
            int x = 140 * index + frmMain.iWidth;
            //y = f(z) = 25z^2 - 150z + height - 160
            int y = frmMain.iHeight - 160 + 25 * index * index - 150 * index;
            return new Point(x, y);
        }

        public override void Draw(Graphics gp)
        {
            Location.X -= 30;
            if (bVisible == true)
            {
                gp.DrawImageUnscaledAndClipped(Img, new Rectangle(Location.X, Location.Y, iWidth, iHeight));
                //gp.DrawRectangle(new Pen(Color.Yellow), new Rectangle(Location.X, Location.Y, iWidth, iHeight));
                if (Location.X + Img.Width <= 0)
                {
                    if (index >= 7) Location = GetLocation();
                    else Location.X = frmMain.iWidth;
                    if (index == 8) bVisible = false;
                }
            }
            else
            {
                if (Location.X + Img.Width <= 0)
                {
                    if (index >= 7) Location = GetLocation();
                    else Location.X = frmMain.iWidth;
                    if (index != 8) bVisible = true;
                }
            }
        }
    }
}