using System.Media;
using System.IO;
using System.Windows.Forms;

namespace OGGY
{
    public static class FX
    {
        private static SoundPlayer player;

        public static void PlayMusic(Stream src)
        {
            using (player = new SoundPlayer(src))
            {
                player.Load();
                player.Play();
            }
        }

        public static void CockroachesLaugh()
        {
            var src = Properties.Resources.CockroachesLaugh;
            PlayMusic(src);
        }

        public static void CoinPickup()
        {
            var src = Properties.Resources.EarnCoin;
            PlayMusic(src);
        }

        public static void Flyswatter()
        {
            var src = Properties.Resources.Flyswatter;
            PlayMusic(src);
        }

        public static void OggyCry()
        {
            var src = Properties.Resources.OggyCry;
            PlayMusic(src);
        }

        public static void OggyHit()
        {
            var src = Properties.Resources.OggyHit_2;
            PlayMusic(src);
        }

        public static void Rocket()
        {
            var src = Properties.Resources.Rocket;
            PlayMusic(src);
        }

        public static void Rolling()
        {
            var src = Properties.Resources.Rolling;
            PlayMusic(src);
        }

        public static void Jump()
        {
            var src = Properties.Resources.Jump;
            PlayMusic(src);
        }
    }
}
