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
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int i = oggy.Run.IndexOf(picOggy.Image);
            if (i + 1 < oggy.Run.Count)
                picOggy.Image = oggy.Run[++i];
            else picOggy.Image = oggy.Run[0];
        }
    }
}
