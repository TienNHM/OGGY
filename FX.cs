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
            string path = "assets/music/Background.wav";
            PlayMusic(path);
        }

        //Code
    }
}
