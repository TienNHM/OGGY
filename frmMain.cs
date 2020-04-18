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
using System.Media;

namespace OGGY
{
    public partial class frmMain : Form
    {
        private BufferedGraphics gp;
        private BufferedGraphicsContext context;
        private Oggy oggy;
        private List<Coin> lCoins;
        private List<VatCan> lVatCan;
        public static int scores = 0;
        private Background background;
        private Random random = new Random(new DateTime().Millisecond);
        SoundPlayer sound = new SoundPlayer(@"D:\Github\OGGY\assets\music\Background.wav");
             
        public frmMain()
        {
            InitializeComponent();
            context = BufferedGraphicsManager.Current;
            gp = context.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            InitGame();
            var assembly = Assembly.GetExecutingAssembly();
            timer.Enabled = true;
            sound.PlayLooping();
        }

        private void InitGame()
        {
            background = new Kitchen();
            oggy = new Oggy();
            lCoins = new List<Coin>();
            for (int i = 0; i < 7; i++)
                lCoins.Add(new Coin(i));
            lVatCan = new List<VatCan>
            {
                new VatCan(VatCan.LoaiVatCan.Bomb),
                new VatCan(VatCan.LoaiVatCan.Chair),
                new VatCan(VatCan.LoaiVatCan.Dynamite),
                new VatCan(VatCan.LoaiVatCan.Hatchet),
                new VatCan(VatCan.LoaiVatCan.Mousetrap),
                new VatCan(VatCan.LoaiVatCan.Plummer)
            };
        }
        int t = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            t++;
            //Each 4.5s
            if (t % 30 == 0)
            {
                int index = random.Next(0, 1000) % 6;
                if (lVatCan[index].bVisible == false)
                    lVatCan[index].bVisible = true;
            }
            Draw(this, new PaintEventArgs(gp.Graphics, this.DisplayRectangle));
            int value = 0;
            if (VaCham.KiemTra(oggy, lVatCan[0], lCoins, ref value))
            {
                //Dung dong ho, ket thuc game
                timer.Enabled = false;
                //Ket thuc game, chuyen sang form Menu de xem ket qua
                this.Close();
            }
            scores += value;
            lblScores.Text = scores.ToString();
        }
        
        public void Draw(object sender, PaintEventArgs e)
        {
            background.Draw(gp.Graphics);
            oggy.Draw(gp.Graphics);
            lVatCan.ForEach(item => item.Draw(gp.Graphics));
            lCoins.ForEach(item => item.Draw(gp.Graphics));
            gp.Render();
        }

        private void frmMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    oggy.Jump();
                    break;
                case Keys.Enter:
                    //
                    break;
            }
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Bạn có muốn kết thúc game không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                if (scores > frmMenu.iHighScore)
                    frmMenu.iHighScore = scores;
                this.Dispose();
            }
        }
    }
}
