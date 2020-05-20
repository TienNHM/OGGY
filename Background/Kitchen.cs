using System;
using System.Collections.Generic;
using System.Drawing;

namespace OGGY.Bground
{
    public class Kitchen : Background
    {
        /// <summary>
        /// Danh sách images của các vật trang trí
        /// </summary>
        private readonly List<Image> images = new List<Image>();

        /// <summary>
        /// Danh sách các Location cảu các Images tương ứng mỗi vật thể 
        /// </summary>
        private readonly List<Point> points = new List<Point>();

        /// <summary>
        /// Dùng để xác định vật trang trí cho background
        /// </summary>
        private int Index { get; set; } = -1;

        /// <summary>
        /// Dùng để random ra vật thể trang trí 
        /// </summary>
        private readonly Random rand = new Random(DateTime.Now.Millisecond);

        public Kitchen()
        {
            background = Properties.Resources.img_background;
            images = new List<Image>
            {
                Properties.Resources.trashbin,
                Properties.Resources.fridge,
                Properties.Resources.chair,
                Properties.Resources.olivia_poster,
                Properties.Resources.locker_bot,
                Properties.Resources.owen,
                Properties.Resources.clock,
            };
            points = new List<Point>
            {
                new Point(frmMain.iWidth, frmMain.iHeight - 170 - images[0].Height),
                new Point(frmMain.iWidth, frmMain.iHeight - 100 - images[1].Height),
                new Point(frmMain.iWidth, frmMain.iHeight - 170 - images[2].Height),
                new Point(frmMain.iWidth, frmMain.iHeight - 460 - images[3].Height),
                new Point(frmMain.iWidth, frmMain.iHeight - 100 - images[4].Height),
                new Point(frmMain.iWidth, frmMain.iHeight - 100 - images[5].Height),
                new Point(frmMain.iWidth, frmMain.iHeight - 500 - images[6].Height),
            };
        }

        public override void Draw(Graphics gp)
        {
            //Draw background
            gp.DrawImageUnscaledAndClipped(background, new Rectangle(0, 0, frmMain.iWidth, frmMain.iHeight));
            if (Index < 0)
            {
                //(-100, c) để tăng khả năng ra Index < 0
                Index = rand.Next(-100, images.Count);
                //Index < 0 thì không cần vẽ thêm các vật minh họa
                if (Index < 0) return;
            }
            //Lấy lại Location 
            points[Index] = new Point(points[Index].X - 30, points[Index].Y);
            //Nếu vật minh họa đã đi qua khỏi biên trái thì không cần vẽ nữa
            if (points[Index].X + images[Index].Width < 0)
            {
                points[Index] = new Point(frmMain.iWidth, points[Index].Y);
                Index = -1;
                //Thoát khỏi, không vẽ nữa
                return;
            }
            gp.DrawImageUnscaledAndClipped(images[Index], new Rectangle(points[Index].X, points[Index].Y, images[Index].Width, images[Index].Height));
        }
    }
}