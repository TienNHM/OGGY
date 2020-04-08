using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGGY
{
    public static class FXMusic
    {
        /// <summary>
        /// Khi oggy nhảy lên
        /// </summary>
        public static void Jump()
        {
            //phát 1 file âm thanh tương ứng
            
        }

        public static void Earns()
        {
            PlayMusic("earn.mp3");
        }


        public static void PlayMusic(string path)
        {
            //WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            //player.URL = path;
            //player.controls.play();
        }
    }
}
