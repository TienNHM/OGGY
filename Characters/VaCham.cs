using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGGY.Characters
{
    public static class VaCham
    {
        public static bool VaChamVatCan(Oggy oggy, VatCan vatCan)
        {
            if (vatCan.bVisible == true)
            {
                Rectangle rect = new Rectangle(Oggy.iLeft, oggy.Location.Y, Oggy.iWidth, Oggy.iHeight);
                //Xét tại tâm vật cản có thuộc region của Oggy
                if (IsInRegion(rect, new Point(vatCan.Location.X + vatCan.Img.Width / 2, vatCan.Location.Y + vatCan.Img.Height / 2)))
                {
                    if (frmMenu.isPlayFXMucsic) FX.OggyHit();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Dùng để xác định số Coin mà Oggy ăn được 
        /// </summary>
        /// <param name="oggy">Nhân vật oggy</param>
        /// <param name="coins">Danh sách các Coins</param>
        /// <returns>Một số nguyên cho biết số coin ăn được </returns>
        public static int Earns(Oggy oggy , List<Coin> coins)
        {
            int re = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].bVisible == true)
                {
                    Rectangle rect = new Rectangle(Oggy.iLeft, oggy.Location.Y + 80, Oggy.iWidth, Oggy.iHeight - 80);
                    if (IsInRegion(rect, new Point(coins[i].Location.X + coins[i].Img.Width / 2, coins[i].Location.Y + coins[i].Img.Height / 2)))
                    {
                        coins[i].bVisible = false;
                        if (i == 7) re += 5;        //Bonus
                        else if (i == 8) re += 10;  //Double Bonus
                        else re++;
                        //Vì tại 1 thời điểm, thực tế chỉ earns 1 coin
                        break;
                    }
                }
            }
            //Play FX music
            if (re > 0 && frmMenu.isPlayFXMucsic) FX.CoinPickup();
            return re;
        }

        /// <summary>
        /// Kiểm tra xem điểm p có nằm trong vùng Rect hay không 
        /// </summary>
        /// <param name="rect">Vùng Rectangle bao quanh Oggy</param>
        /// <param name="p">Điểm p dùng để xét xem có thuộc vùng Rect hay không </param>
        /// <returns></returns>
        private static bool IsInRegion(Rectangle rect, Point p)
        {
            if (rect.Left <= p.X && p.X <= rect.Right - 20)
                if (rect.Top <= p.Y && p.Y <= rect.Bottom)
                {
                    return true;
                }
            return false;
        }
    }
}
