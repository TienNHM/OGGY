using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Net;

namespace OGGY.Characters
{
    public class Oggy : Character
    {
        #region Fields
        /// <summary>
        /// Chứa bound của Oggy khi chạy 
        /// </summary>
        private Rectangle runRect { get; }

        /// <summary>
        /// Dùng để xác định hình đang được vẽ 
        /// </summary>
        private int indexOggyPic = 0;

        /// <summary>
        /// Dùng để xác định trạng thái hiện tại của Oggy
        /// </summary>
        private STATE currentState = STATE.NONE;
        #endregion

        #region Properties
        /// <summary>
        /// Chứa danh sách các hình Oggy khi chạy 
        /// </summary>
        private List<Image> lRun { get; set; } = new List<Image>();

        /// <summary>
        /// Chứa danh sách các hình của Oggy khi nhảy 
        /// </summary>
        private List<Image> lJump { get; set; } = new List<Image>();

        /// <summary>
        /// Chứa danh sách cách hình của Oggy khi va chạm 
        /// </summary>
        private List<Image> lConflict { get; set; } = new List<Image>();
        public static int iWidth { get; } = 175;
        public static int iHeight { get; } = 240;
        public static int iLeft { get; } = 80;
        public static int iTop { get; } = frmMain.iHeight - 280;

        public int Stars = 3;
        #endregion

        public Oggy()
        {
            Stars = 3;
            Location = new Point(iLeft, iTop);
            runRect = new Rectangle(iLeft, iTop, iWidth, iHeight);
            var assembly = Assembly.GetExecutingAssembly();
            for (int i = 0; i < 12; i++)
            {
                lRun.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-run-{i}.png")));
                lJump.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-jump-{i}.png")));
            }
            for (int i = 1; i < 6; i++)
            {
                lConflict.Add(Image.FromStream(assembly.GetManifestResourceStream($"OGGY.assets.oggy.oggy-headhit-00{i}.png")));
            }
        }

        /// <summary>
        /// Được gọi khi player nhấn UP.
        /// </summary>
        public void Jump()
        {
            currentState = STATE.JUMP;
            indexOggyPic = 0;
        }

        /// <summary>
        /// Được gọi khi có va chạm giữa Oggy và vật cản 
        /// </summary>
        public void Conflict()
        {
            currentState = STATE.CONFLICT;
            indexOggyPic = 0;
        }

        public override void Draw(Graphics gp)
        {
            if (currentState == STATE.JUMP)
            {
                if (indexOggyPic < lJump.Count)
                {
                    Location = GetLocation();
                    gp.DrawImageUnscaledAndClipped(lJump[indexOggyPic++], new Rectangle(iLeft, Location.Y, iWidth, iHeight));
                    //gp.DrawRectangle(new Pen(Color.Red), new Rectangle(Location.X, Location.Y, iWidth, iHeight));
                }
                else
                {
                    indexOggyPic = 0;
                    currentState = STATE.NONE;
                    Location = new Point(iLeft, iTop);
                }
            }
            else if (currentState == STATE.CONFLICT)
            {
                if (indexOggyPic < lConflict.Count)
                {
                    gp.DrawImageUnscaledAndClipped(lConflict[indexOggyPic++], new Rectangle(iLeft, Location.Y, iWidth, iHeight));
                    //gp.DrawRectangle(new Pen(Color.Red), new Rectangle(Location.X, Location.Y, iWidth, iHeight));
                }
                else
                {
                    indexOggyPic = 0;
                    currentState = STATE.NONE;
                    Location = new Point(iLeft, iTop);
                }
            }
            else if (currentState == STATE.NONE)
            {
                if (indexOggyPic >= lRun.Count) indexOggyPic = 0;
                gp.DrawImageUnscaledAndClipped(lRun[indexOggyPic++], runRect);
                //gp.DrawRectangle(new Pen(Color.Red), new Rectangle(Location.X, Location.Y, iWidth, iHeight));
            }
        }

        /// <summary>
        /// Dùng để xác định Location của Oggy khi nhảy lên 
        /// </summary>
        /// <returns>Location của Oggy khi nhảy lên, là một Point</returns>
        protected override Point GetLocation()
        {
            int index = indexOggyPic;
            int y = iTop;
            int iHight_EachStep = frmMain.iHeight / 12;
            if (index < 6) y -= iHight_EachStep * index;
            else y -= iHight_EachStep * (12 - index);
            return new Point(iLeft, y);
        }

        private enum STATE
        {
            JUMP,
            CONFLICT,
            NONE
        }
    }
}