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
        public frmMain()
        {
            InitializeComponent();
            var assembly = Assembly.GetExecutingAssembly();
            var filePath = "OGGY.assets.oggy.oggy-angel-00.png";
            pictureBox1.Image = Image.FromStream(assembly.GetManifestResourceStream(filePath));

            //Do something.........
            //
        }
    }
}
