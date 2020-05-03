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
            if (index < 7)
                Img = Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.game.coin{index}.png"));
            else if (index == 7)
                Img = Image.FromStream(assembly.GetManifestResourceStream("OGGY.assets.game.hud-powerbtn.png"));
            else if (index == 8)
                Img = Image.FromStream(assembly.GetManifestResourceStream("OGGY.assets.game.heart_full.png"));
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
            if (bVisible == true)
            {
                Location.X -= 30;
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
                Location.X -= 30;
                if (Location.X + Img.Width <= 0)
                {
                    if (index != 8) bVisible = true;
                    if (index >= 7) Location = GetLocation();
                    else Location.X = frmMain.iWidth;
                }
            }
        }
    }
}