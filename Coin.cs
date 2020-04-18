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
        public static int iWidth = 32;
        public static int iHeight = 45;
        public bool bVisible { get; set; } = true;
        public readonly int index;

        public Coin(int index)
        {
            this.index = index;
            Assembly assembly = Assembly.GetExecutingAssembly();
            Img = Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.game.coin{index}.png"));
            Location = GetLocation();
        }

        protected override Point GetLocation()
        {
            int x = 140 * index + 1300;
            //y = f(z) = 25z^2 - 150z + 580
            int y = 25 * index * index - 150 * index + 580;
            return new Point(x, y);
        }

        public void GetX()
        {
          
        }

        public override void Draw(Graphics gp)
        {
            if (bVisible == true)
            {
                int x = Location.X - 30;
                if (x < 0)
                {
                    x = 1300;
                    bVisible = false;
                }
                Location = new Point(x, Location.Y);
                gp.DrawImage(Img, Location);
            }
        }
    }
}