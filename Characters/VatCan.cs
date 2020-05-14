using System.Drawing;
using System.Reflection;

namespace OGGY.Characters
{
    public class VatCan : Character
    {
        /// <summary>
        /// Draw nếu true 
        /// </summary>
        public bool bVisible { get; set; }

        /// <summary>
        /// Sinh ra vật cản tùy thuộc vào LoaiVatCan 
        /// </summary>
        /// <param name="type">Là một LoaiVatCan được liệt kê </param>
        public VatCan(LoaiVatCan type)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            try
            {
                switch (type)
                {
                    case LoaiVatCan.Bomb:
                        Img = Properties.Resources.bomb;
                        break;
                    case LoaiVatCan.Dynamite:
                        Img = Properties.Resources.dynamite;
                        break;
                    case LoaiVatCan.Hatchet:
                        Img = Properties.Resources.hatchet;
                        break;
                    case LoaiVatCan.Mousetrap:
                        Img = Properties.Resources.mousetrap;
                        break;
                    case LoaiVatCan.Plummer:
                        Img = Properties.Resources.plummer;
                        break;
                    case LoaiVatCan.Toaster:
                        Img = Properties.Resources.toaster;
                        break;
                }
                Location = new Point(frmMain.iWidth, frmMain.iHeight - 50 - Img.Height);
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
                if (Location.X - 30 + Img.Width <= 0)
                {
                    bVisible = false;
                    Location.X = frmMain.iWidth;
                }
                else
                {
                    Location.X -= 30;
                    gp.DrawImage(Img, Location);
                    //gp.DrawRectangle(new Pen(Color.Blue), new Rectangle(Location.X, Location.Y, Img.Width, Img.Height));
                }
            }
        }

        /// <summary>
        /// Dùng để xác định loại vật cản được sinh ra 
        /// </summary>
        public enum LoaiVatCan
        {
            Bomb,
            Dynamite,
            Hatchet,
            Mousetrap,
            Plummer,
            Toaster
        }

        protected override Point GetLocation()
        {
            return new Point();
        }
    }
}