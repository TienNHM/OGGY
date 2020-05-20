using OGGY.Bground;
using OGGY.Characters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OGGY
{
    public partial class frmMain : Form
    {
        #region Properties 
        public static int scores = 0;
        public static int iWidth = 1300;
        public static int iHeight = 700;
        private BufferedGraphics gp;
        private BufferedGraphicsContext context;

        /// <summary>
        /// Nhân vật của game 
        /// </summary>
        private Oggy oggy;

        /// <summary>
        /// Chứa danh sách các coin được khởi tạo 
        /// </summary>
        private List<Coin> lCoins;

        /// <summary>
        /// Chứa danh sách các vật cản được khởi tạo 
        /// </summary>
        private List<VatCan> lVatCan;

        /// <summary>
        /// Dùng để chứa các picturebox là các stars còn lại của oggy 
        /// </summary>
        private List<PictureBox> picStars;

        /// <summary>
        /// Dùng để xác định background của game 
        /// </summary>
        private Background background;

        private Random random = new Random(new DateTime().Millisecond);

        /// <summary>
        /// Dùng để xác định index của vật cản đang được vẽ 
        /// </summary>
        private int indexVatCan { get; set; } = -1;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            context = BufferedGraphicsManager.Current;
            gp = context.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            InitGame();
            PlayFXMucsic();
            timer.Enabled = true;
            iWidth = this.Width;
            iHeight = this.Height;
            indexVatCan = -1;
        }

        /// <summary>
        /// Khởi tạo các giá trị ban đầu của game 
        /// </summary>
        private void InitGame()
        {
            background = new Kitchen();
            oggy = new Oggy();
            lCoins = new List<Coin>();
            picStars = new List<PictureBox> { picStar01, picStar02, picStar03 };
            for (int i = 0; i < 9; i++)
                lCoins.Add(new Coin(i));
            lCoins[8].bVisible = false;
            lVatCan = new List<VatCan>
            {
                new VatCan(VatCan.LoaiVatCan.Bomb),
                new VatCan(VatCan.LoaiVatCan.Dynamite),
                new VatCan(VatCan.LoaiVatCan.Hatchet),
                new VatCan(VatCan.LoaiVatCan.Mousetrap),
                new VatCan(VatCan.LoaiVatCan.Plummer),
                new VatCan(VatCan.LoaiVatCan.Toaster)
            };
            scores = 0;
        }

        /// <summary>
        /// Dùng để xác định index của vật cản được vẽ 
        /// </summary>
        private void GetIndex()
        {
            if (scores % 5 == 3)
            {
                indexVatCan = lVatCan.TrueForAll(vc => vc.bVisible == false) ? -1 : indexVatCan;
                if (indexVatCan == -1)
                {
                    indexVatCan = random.Next(0, 2 * lVatCan.Count) % lVatCan.Count;
                    lVatCan[indexVatCan].bVisible = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (scores % 20 == 0) lCoins[8].bVisible = true;
            Draw(this, new PaintEventArgs(gp.Graphics, this.DisplayRectangle));
            GetIndex();
            if (indexVatCan >= 0)
            {
                //if (lVatCan[indexVatCan].VaCham(oggy))
                if (VaCham.VaChamVatCan(oggy, lVatCan[indexVatCan]))
                {
                    oggy.Stars--;
                    picStars[oggy.Stars].Visible = false;
                    if (oggy.Stars == 0)
                        EndGame();
                    else
                    {
                        lVatCan[indexVatCan].bVisible = false;
                        lVatCan[indexVatCan].Location.X = frmMain.iWidth;
                    }
                }
            }
            scores += VaCham.Earns(oggy, lCoins);
            lblScores.Text = scores.ToString();
        }

        private void EndGame()
        {
            //Dung dong ho, ket thuc game
            timer.Enabled = false;
            if (frmMenu.isPlayFXMucsic) FX.OggyCry();
            //Ket thuc game, chuyen sang form Menu de xem ket qua
            using (var endGame = new EndGame(scores))
            {
                endGame.ShowDialog();
            }
            this.Dispose();
        }

        /// <summary>
        /// Dùng để vẽ tất cả các thành phần Graphics mỗi khi timer_Tick()
        /// </summary>
        /// <param name="sender">Form sinh ra Graphics </param>
        /// <param name="e">PaintEventArgs</param>
        public void Draw(object sender, PaintEventArgs e)
        {
            background.Draw(gp.Graphics);
            oggy.Draw(gp.Graphics);
            if (indexVatCan >= 0) lVatCan[indexVatCan].Draw(gp.Graphics);
            lCoins.ForEach(item => item.Draw(gp.Graphics));
            gp.Render();
        }

        private void FrmMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    oggy.Jump();
                    //FX.Jump();
                    break;
                case Keys.Enter:
                    //Tăng tốc 
                    Draw(this, new PaintEventArgs(gp.Graphics, this.DisplayRectangle));
                    break;
            }
        }

        private void LblQuit_Click(object sender, EventArgs e)
        {
            lblPause_Click(lblPause, new EventArgs());
            DialogResult ans = MessageBox.Show("Bạn có muốn kết thúc game không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                if (scores > frmMenu.iHighScore)
                    frmMenu.iHighScore = scores;
                this.Dispose();
            }
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            lblPause.Visible = false;
            lblPlay.Visible = true;
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            lblPlay.Visible = false;
            lblPause.Visible = true;
        }

        private void picFXMusic_Click(object sender, EventArgs e)
        {
            frmMenu.isPlayFXMucsic = !frmMenu.isPlayFXMucsic;
            PlayFXMucsic();
        }

        private void PlayFXMucsic()
        {
            if (frmMenu.isPlayFXMucsic)
                picFXMusic.BackgroundImage = OGGY.Properties.Resources.opt_music;
            else
                picFXMusic.BackgroundImage = OGGY.Properties.Resources.opt_nomusic;
        }
    }
}
