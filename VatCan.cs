using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Reflection;

namespace OGGY
{
    public class VatCan : Character, IMovable
    {
        public static int iWidth = 0;
        public static int iHeight = 0;
        public int iTop = 0;
        public int iLeft = 0;
        public bool bVisible;
        public GraphicsPath gpBorder = new GraphicsPath();

        public VatCan(LoaiVatCan type)
        {
            var asm = Assembly.GetExecutingAssembly();
            try
            {
                switch (type)
                {
                    case LoaiVatCan.Bomb:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.game.bomb.png"));
                        break;
                    case LoaiVatCan.Chair:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.kitchen.chair.png"));
                        break;
                    case LoaiVatCan.Dynamite:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.game.dynamite.png"));
                        break;
                    case LoaiVatCan.Hatchet:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.game.hatchet.png"));
                        break;
                    case LoaiVatCan.Mousetrap:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.kitchen.mousetrap.png"));
                        break;
                    case LoaiVatCan.Plummer:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.game.plummer.png"));
                        break;
                }
                iWidth = Img.Width;
                iHeight = Img.Height;
                iLeft = frmMain.iWidth;
                iTop = frmMain.iHeight - 60 - iHeight;
                Location = new Point(iLeft, iTop);
                gpBorder.AddRectangle(new Rectangle(Location.X, Location.Y, iWidth, iHeight));
                bVisible = false;
            }
            catch
            {
                
            }   
        }

        public override void Draw(Graphics gp)
        {
            if (bVisible)
            {
                int x = Location.X - 30;
                if (x < 0) bVisible = false;
                else
                {
                    Location = new Point(x, Location.Y);
                    gp.DrawImage(Img, Location);
                }
                gpBorder.AddRectangle(new Rectangle(Location.X, Location.Y, iWidth, iHeight));
            }
        }

        public enum LoaiVatCan
        {
            Bomb,
            Chair,
            Dynamite,
            Hatchet,
            Mousetrap,
            Plummer
        }

        protected override Point GetLocation()
        {
            return new Point();
        }
    }
}