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
        #region Properties
        public List<Image> lRun = new List<Image>();
        public List<Image> lJump = new List<Image>();
        public static int iWidth = 175;
        public static int iHeight = 240;
        private int indexOggyPic = 0;
        private bool isJump = false;
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Point P4 { get; set; }
        #endregion

        public Oggy()
        {
            var assembly = Assembly.GetExecutingAssembly();
            for (int i = 0; i < 12; i++)
            {
                lRun.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-run-{i}.png")));
            }
            for (int i = 0; i < 10; i++)
            {
                lJump.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-jump-{i}.png")));
            }
            P1 = Location = new Point(80, 380);
            P2 = new Point(Location.X + iWidth, Location.Y);
            P3 = new Point(Location.X, Location.Y + iHeight);
            P4 = new Point(Location.X + iWidth, Location.Y + iHeight);
        }

        public void Jump()
        {
            isJump = true;
            indexOggyPic = 0;
        }

        public override void Draw(Graphics gp)
        {
            if (isJump)
            {
                if (indexOggyPic < lJump.Count)
                {
                    Location = GetLocation();
                    gp.DrawImageUnscaled(lJump[indexOggyPic++], Location);
                }
                else
                {
                    indexOggyPic = 0;
                    isJump = false;
                    Location = new Point(80, 380);
                }
            }
            else
            {
                if (indexOggyPic < lRun.Count)
                    gp.DrawImageUnscaled(lRun[indexOggyPic++], Location);
                else
                {
                    indexOggyPic = 0;
                    gp.DrawImageUnscaled(lRun[indexOggyPic++], Location);
                }
            }
        }

        protected override Point GetLocation()
        {
            int index = indexOggyPic;
            int y = 380;
            if (index < 5) y -= 60 * index;
            else y = 120 + 60 * (index - 5);
            return new Point(Location.X, y);
        }
    }
}