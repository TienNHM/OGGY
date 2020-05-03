using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace OGGY
{
    public partial class frmMenu : Form
    {
        public static int iHighScore = 0;
        private SoundPlayer player = new SoundPlayer();
        private bool isPlayBgMusic = false;
        private bool isPlayFXMucsic = false;

        public frmMenu()
        {
            InitializeComponent();
            lblHighScore.Text = iHighScore.ToString();
        }

        private void PicNew_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            player.Stop();
            this.Hide();
            frmMain.ShowDialog();
            this.Show();
            PlayBackgroundMusic();
            if (iHighScore < frmMain.scores)
                iHighScore = frmMain.scores;
            lblHighScore.Text = iHighScore.ToString();
        }

        private void PicFXMusic_Click(object sender, EventArgs e)
        {
            isPlayFXMucsic = !isPlayFXMucsic;
            if (isPlayFXMucsic)
                picFXMusic.BackgroundImage = OGGY.Properties.Resources.opt_music;
            else
                picFXMusic.BackgroundImage = OGGY.Properties.Resources.opt_nomusic;
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Bạn muốn thoát game chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
                Application.Exit();
        }

        private void PicInfo_Click(object sender, EventArgs e)
        {

        }

        private void PicBgMusic_Click(object sender, EventArgs e)
        {
            isPlayBgMusic = !isPlayBgMusic;
            PlayBackgroundMusic();
        }

        private void PlayBackgroundMusic()
        {
            if (isPlayBgMusic)
            {
                picBgMusic.BackgroundImage = OGGY.Properties.Resources.opt_sound;
                player = new SoundPlayer("assets/music/Background.wav");
                player.PlayLooping();
            }
            else
            {
                picBgMusic.BackgroundImage = OGGY.Properties.Resources.opt_nosound;
                player.Stop();
            }
        }
    }
}
