using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace OGGY
{
    public class Kitchen : Background
    {
        public Kitchen()
        {
            var asm = Assembly.GetExecutingAssembly();
            background = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.menu.background.png"));
        }

        public override void Draw(Graphics gp)
        {
            gp.DrawImage(background, 0, 0);
        }

    }
}