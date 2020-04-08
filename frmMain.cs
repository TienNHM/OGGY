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

namespace OGGY
{
    public partial class frmMain : Form
    {
        BufferedGraphics gp;
        BufferedGraphicsContext context;
        private Oggy oggy;
        private List<Coin> lCoins;
        private int scores = 0;
        private Image background;
        public frmMain()
        {
            InitializeComponent();
            context = BufferedGraphicsManager.Current;
            gp = context.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            InitGame();
            var assembly = Assembly.GetExecutingAssembly();
            background = Image.FromStream(assembly.GetManifestResourceStream("OGGY.assets.menu.background.png"));
            timer.Enabled = true;
        }

        private void InitGame()
        {
            oggy = new Oggy();
            lCoins = new List<Coin>();
            for (int i = 0; i < 7; i++)
                lCoins.Add(new Coin(i));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Draw(this, new PaintEventArgs(gp.Graphics, this.DisplayRectangle));
            scores += oggy.Earns(lCoins);
            lblScores.Text = scores.ToString();
        }
        
        public void Draw(object sender, PaintEventArgs e)
        {
            gp.Graphics.DrawImageUnscaled(background, 0, 0);
            oggy.Draw(gp.Graphics);

            lCoins.ForEach(item => item.GetX());
            for (int index = 0; index < lCoins.Count; index++)
            {
                lCoins[index].GetX();
                lCoins[index].Draw(gp.Graphics);
            }
            gp.Render();
        }
        public int Earns()
        {
            int count = 0;
            //for (int i = 0; i < lCoins.Count; i++)
            //{
            //    if (lCoins[i].bEarned == false)
            //        if (lCoins[i].Item.Left >= picOggy.Left && lCoins[i].Item.Left <= picOggy.Left + picOggy.Width && lCoins[i].Item.Top + 45 >= picOggy.Top)
            //        {
            //            count++;
            //            lCoins[i].bEarned = true;
            //            lCoins[i].Item.Visible = false;
            //        }
            //}
            return count;
        }
    }
}
