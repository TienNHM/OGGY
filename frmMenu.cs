using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OGGY
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //Để lấy resources có trong project thì có vài cách (theo tui biết):
            //1. Thêm vào file Resources.resx trong Properties
            //2. Thêm 1 thư mục vào projects
            //
            // Giờ xem cách 1 nha:
            //1.1. Solution Explorer -> Properties -> Resources -> Mở file Resources.resx
            //1.2 Add resources -> Add existing file.... -> Chọn file rồi add vào thôi
            //1.3 Sử dụng: {Tên namespace}.Properties.Resources.<tên file>;
            //pictureBox1.Image = OGGY.Properties.Resources.aim_000;
            pictureBox1.Image = OGGY.Properties.Resources.opt_music;
            pictureBox2.Image = OGGY.Properties.Resources.opt_sound;
            pictureBox3.Image = OGGY.Properties.Resources.logo_text_EN;
            //
            // Cách 2. Add file/thư mục (như tui đã làm)
            // 2.1 using System.Reflection;
            // 2.2 var assembly = Assembly.GetExecutingAssembly();
            // 2.3 (...) = Image.FromStream(assembly.GetManifestResourceStream("OGGY.TMP.baloon0001.png"));
            //var assembly = Assembly.GetExecutingAssembly();
            //pictureBox2.Image = Image.FromStream(assembly.GetManifestResourceStream("OGGY.TMP.baloon0001.png"));


        }

        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //string path = $"OGGY.TMP.oggy-gameover-red-0{i}.png";
            //pictureBox2.Image = Image.FromStream(assembly.GetManifestResourceStream(path));
            //i++;
            //if (i > 8) i = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            //player.URL = "1.mp3";
            //player.controls.play();

            string Path_NhacNen = "1.mp3";
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            //Phát Nhạc
            mciSendString("open \"" + Path_NhacNen + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile REPEAT", null, 0, IntPtr.Zero);
        }

        #region Events
        [DllImport("winmm.dll")]
        public static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        #endregion
    }
}
