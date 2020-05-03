using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Reflection;

namespace OGGY
{
    public static class FX
    {
        static SoundPlayer player;
        static void PlayMusic(string path)
        {
            player = new SoundPlayer(path);
            player.PlaySync();
        }

        public static void Background()
        {
            //Duong dan den file *.wav
            //Truy xuat file nhu cach hôm tui làm Assembly
            string path = "assets/music/Background.wav";
            //Vì đã embbed vào project nên file đã nằm trong thư mục bin rồi
            //ông chỉ cần truy cập theo thư mục như trên
            PlayMusic(path);
        }

        public static void CockroachesLaugh()
        {
            string path = "assets/music/CockroachesLaugh.wav";
            PlayMusic(path);
        }

        public static void CoinPickup()
        {
            string path = "assets/music/CoinPickup.wav";
            PlayMusic(path);
        }

        public static void Flyswatter()
        {
            string path = "assets/music/Flyswatter1.wav";
            PlayMusic(path);
        }

        public static void Menu()
        {
            string path = "assets/music/Menu.wav";
            PlayMusic(path);
        }

        public static void OggyCry()
        {
            string path = "assets/music/OggyCry.wav";
            PlayMusic(path);
        }

        public static void OggyHit()
        {
            string path = "assets/music/OggyHit_2.wav";
            PlayMusic(path);
        }

        public static void Rocket()
        {
            string path = "assets/music/Rocket.wav";
            PlayMusic(path);
        }

        public static void Rolling()
        {
            string path = "assets/music/Rolling.wav";
            PlayMusic(path);
        }
    }
}
