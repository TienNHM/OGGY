using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace OGGY
{
    public class Oggy : Character
    {
        public List<Image> lRun = new List<Image>();
        public List<Image> lJump = new List<Image>();
        public static int iWidth = 175;
        public static int iHeight = 240;
        public static readonly int iTop = 380;
        private static int indexOggyPic = 0;

        public Oggy()
        {
            var assembly = Assembly.GetExecutingAssembly();
            for (int i = 0; i < 12; i++)
            {
                lRun.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-run-{i}.png")));
            }
            for (int i = 0; i < 8; i++)
            {
                lJump.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-jump-{i}.png")));
            }
        }

        public void Draw(Graphics gp)
        {
            if (indexOggyPic < lRun.Count)
                gp.DrawImageUnscaled(lRun[indexOggyPic++], 50, iTop);
            else
            {
                indexOggyPic = 0;
                gp.DrawImageUnscaled(lRun[indexOggyPic++], 80, iTop);
            }
        }
    }
}