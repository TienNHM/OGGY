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
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.game.bomb.png"));
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
                    case LoaiVatCan.Toaster:
                        Img = Image.FromStream(asm.GetManifestResourceStream("OGGY.assets.game.toaster.png"));
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

        /// <summary>
        /// Xác định sự va chạm giữa vật cản với Oggy 
        /// </summary>
        /// <param name="oggy">Là instance hiện tại của class Oggy </param>
        /// <returns>true nếu va chạm</returns>
        public bool VaCham(Oggy oggy)
        {
            if (bVisible == true)
            {
                Rectangle rect = new Rectangle(Oggy.iLeft, oggy.Location.Y, Oggy.iWidth, Oggy.iHeight);
                //Xét tại tâm vật cản có thuộc region của Oggy
                if (IsInRegion(rect, new Point(Location.X + Img.Width / 2, Location.Y + Img.Height / 2))) return true;
            }
            return false;
        }

        /// <summary>
        /// Kiểm tra xem điểm p có nằm trong vùng Rect hay không 
        /// </summary>
        /// <param name="rect">Vùng Rectangle bao quanh Oggy</param>
        /// <param name="p">Điểm p dùng để xét xem có thuộc vùng Rect hay không </param>
        /// <returns></returns>
        private static bool IsInRegion(Rectangle rect, Point p)
        {
            if (rect.X <= p.X && p.X <= rect.X + rect.Width - 20)
                if (rect.Y <= p.Y && p.Y <= rect.Y + rect.Height)
                {
                    return true;
                }
            return false;
        }
    }
}