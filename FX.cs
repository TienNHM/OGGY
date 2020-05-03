using System.Media;

namespace OGGY
{
    public static class FX
    {
        private static SoundPlayer player;

        static void PlayMusic(string path)
        {
            using (player = new SoundPlayer(path))
            {
                player.Load();
                player.Play();
            }
        }

        public static void Background()
        {
            string path = "assets/music/Background.wav";
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

        public static void Jump()
        {
            string path = "assets/music/Jump.wav";
            PlayMusic(path);
        }
    }
}
