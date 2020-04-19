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
        #endregion

        public Oggy()
        {
            Location = new Point(80, frmMain.iHeight / 2);
            var assembly = Assembly.GetExecutingAssembly();
            for (int i = 0; i < 12; i++)
            {
                lRun.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-run-{i}.png")));
            }
            for (int i = 0; i < 10; i++)
            {
                lJump.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-jump-{i}.png")));
            }
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
                    gp.DrawImage(lJump[indexOggyPic++], Location);
                }
                else
                {
                    indexOggyPic = 0;
                    isJump = false;
                    Location = new Point(80, frmMain.iHeight/2);
                }
            }
            else
            {
                if (indexOggyPic < lRun.Count)
                    gp.DrawImage(lRun[indexOggyPic++], Location);
                else
                {
                    indexOggyPic = 0;
                    gp.DrawImage(lRun[indexOggyPic++], Location);
                }
            }
        }

        protected override Point GetLocation()
        {
            int index = indexOggyPic;
            int y = frmMain.iHeight / 2;
            int iHight_EachStep = (int)((6.0 / 70) * frmMain.iHeight);
            if (index < 5) y -= iHight_EachStep * index;
            else y += iHight_EachStep * (index - 9);
            return new Point(Location.X, y);
        }
    }
}