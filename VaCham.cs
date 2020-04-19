using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OGGY
{
    public static class VaCham
    {
        public static bool KiemTra(Oggy oggy, VatCan vatCan, List<Coin> coins, ref int value)
        {
            value = Earns(oggy, coins);
            return VaChamVatThe(oggy, vatCan);
        }

        private static int Earns(Oggy oggy, List<Coin> lCoins)
        {
            int re = 0;
            int right = oggy.Location.X + Oggy.iWidth;
            lCoins.ForEach(coin =>
            {
                if (coin.bVisible == true)
                    if (coin.Location.X <= right && coin.Location.Y + Coin.iHeight >= oggy.Location.Y + 80)
                    {
                        re++;
                        coin.bVisible = false;
                    }
            });
            return re;
        }

        private static bool VaChamVatThe(Oggy oggy, VatCan vatCan)
        {
            if (vatCan.bVisible == true)
            {
                int oggy_r = oggy.Location.X + Oggy.iWidth - 20;
                int vatCan_r = vatCan.Location.X + vatCan.Img.Width;
                if ((vatCan.Location.X >= oggy.Location.X && vatCan.Location.X <= oggy_r)
                    || (vatCan_r >= oggy.Location.X && vatCan_r <= oggy_r))
                {
                    int oggy_bot = oggy.Location.Y + Oggy.iHeight;
                    if (vatCan.Location.Y >= oggy.Location.Y || vatCan.Location.Y <= oggy_bot)
                        return true;
                }
            }
            return false;
        }
    }
}
 