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
            //Để lấy resources có trong project thì có vài cách (theo tui biết):
            //1. Thêm vào file Resources.resx trong Properties
            //2. Thêm 1 thư mục vào projects
            //
            // Giờ xem cách 1 nha:
            //1.1. Solution Explorer -> Properties -> Resources -> Mở file Resources.resx
            //1.2 Add resources -> Add existing file.... -> Chọn file rồi add vào thôi
            //1.3 Sử dụng: {Tên namespace}.Properties.Resources.<tên file>;
            //pictureBox1.Image = OGGY.Properties.Resources.aim_000;
            pictureBox1.Image = OGGY.Properties.Resources.bomb;
            //
            // Cách 2. Add file/thư mục (như tui đã làm)
            // 2.1 using System.Reflection;
            // 2.2 var assembly = Assembly.GetExecutingAssembly();
            // 2.3 (...) = Image.FromStream(assembly.GetManifestResourceStream("OGGY.TMP.baloon0001.png"));
            //var assembly = Assembly.GetExecutingAssembly();
            //pictureBox2.Image = Image.FromStream(assembly.GetManifestResourceStream("OGGY.TMP.baloon0001.png"));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOptions Option = new frmOptions();
            Option.Show();
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
    }
}
