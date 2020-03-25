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
        public PictureBox Item;
        public static int iWidth = 32;
        public static int iHeight = 45;

        public Coin(int index)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Item = new PictureBox()
            {
                Image = Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.game.coin{index}.png")),
                BackColor = Color.Transparent,
                Location = GetLocation(index),
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = iWidth,
                Height = iHeight
            };
        }

        private Point GetLocation(int index)
        {
            int x = 140 * index + 1200;
            //y = f(x) = -45x^2 + 315x + 500
            int y = 25 * index * index - 150 * index + 500;
            return new Point(x, y);
        }

        public void GetX()
        {
            Item.Left -= 40;
        }
    }
}