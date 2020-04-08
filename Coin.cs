using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OGGY
{
    public class Coin : Character, IMovable
    {
        public Image Img;
        public Point Location;
        public static int iWidth = 32;
        public static int iHeight = 45;
        public bool bEarned = false;

        public Coin(int index)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Img = Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.game.coin{index}.png"));
            Location = GetLocation(index);
        }

        private Point GetLocation(int index)
        {
            int x = 140 * index + 1200;
            //y = f(z) = 25z^2 - 150z + 500
            int y = 25 * index * index - 150 * index + 500;
            return new Point(x, y);
        }

        public void GetX()
        {
            int x = Location.X - 30;
            if (x < 0)
            {
                x = 1200;
                bEarned = false;
            }
            Location = new Point(x, Location.Y);
        }

        public void Draw(Graphics gp)
        {
            if (bEarned == false)
                gp.DrawImage(Img, Location);
        }
    }
}