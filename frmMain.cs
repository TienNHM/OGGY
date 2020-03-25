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
        private Oggy oggy;
        private List<Coin> lCoins;
        public frmMain()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            var assembly = Assembly.GetExecutingAssembly();
            this.BackgroundImage = Image.FromStream(assembly.GetManifestResourceStream("OGGY.assets.kitchen.bg_00.png"));
            oggy = new Oggy();
            lCoins = new List<Coin>();
            for (int i = 0; i < 7; i++)
            {
                lCoins.Add(new Coin(i));
                Controls.Add(lCoins[i].Item);
                lCoins[i].Item.BringToFront();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int i = oggy.lRun.IndexOf(picOggy.Image);
            if (i + 1 < oggy.lRun.Count)
                picOggy.Image = oggy.lRun[++i];
            else picOggy.Image = oggy.lRun[0];
            lCoins.ForEach(item => item.GetX());
        }
    }
}
