namespace OGGY
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFXMusic = new System.Windows.Forms.PictureBox();
            this.picBgMusic = new System.Windows.Forms.PictureBox();
            this.picNew = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFXMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picFXMusic
            // 
            this.picFXMusic.BackColor = System.Drawing.Color.Transparent;
            this.picFXMusic.BackgroundImage = global::OGGY.Properties.Resources.opt_nomusic;
            this.picFXMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFXMusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.picFXMusic.Location = new System.Drawing.Point(70, 0);
            this.picFXMusic.Margin = new System.Windows.Forms.Padding(2);
            this.picFXMusic.Name = "picFXMusic";
            this.picFXMusic.Size = new System.Drawing.Size(70, 51);
            this.picFXMusic.TabIndex = 5;
            this.picFXMusic.TabStop = false;
            this.picFXMusic.Click += new System.EventHandler(this.PicFXMusic_Click);
            // 
            // picBgMusic
            // 
            this.picBgMusic.BackColor = System.Drawing.Color.Transparent;
            this.picBgMusic.BackgroundImage = global::OGGY.Properties.Resources.opt_nosound;
            this.picBgMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBgMusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBgMusic.Location = new System.Drawing.Point(0, 0);
            this.picBgMusic.Margin = new System.Windows.Forms.Padding(2);
            this.picBgMusic.Name = "picBgMusic";
            this.picBgMusic.Size = new System.Drawing.Size(70, 51);
            this.picBgMusic.TabIndex = 6;
            this.picBgMusic.TabStop = false;
            this.picBgMusic.Click += new System.EventHandler(this.PicBgMusic_Click);
            // 
            // picNew
            // 
            this.picNew.BackColor = System.Drawing.Color.Transparent;
            this.picNew.Image = global::OGGY.Properties.Resources.new_badge_en;
            this.picNew.Location = new System.Drawing.Point(599, 473);
            this.picNew.Margin = new System.Windows.Forms.Padding(2);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(219, 111);
            this.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNew.TabIndex = 8;
            this.picNew.TabStop = false;
            this.picNew.Click += new System.EventHandler(this.PicNew_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::OGGY.Properties.Resources.menu_fridge;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(22, 207);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(188, 445);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImage = global::OGGY.Properties.Resources.counter_plus;
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picInfo.Location = new System.Drawing.Point(140, 0);
            this.picInfo.Margin = new System.Windows.Forms.Padding(2);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(70, 51);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 10;
            this.picInfo.TabStop = false;
            this.picInfo.Click += new System.EventHandler(this.PicInfo_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::OGGY.Properties.Resources.bob_sleep_00;
            this.pictureBox7.Location = new System.Drawing.Point(958, 537);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(200, 202);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.White;
            this.lblHighScore.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblHighScore.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHighScore.Location = new System.Drawing.Point(53, 370);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(139, 58);
            this.lblHighScore.TabIndex = 13;
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::OGGY.Properties.Resources.logo_text_EN;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(254, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 388);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.picExit);
            this.panel2.Controls.Add(this.picInfo);
            this.panel2.Controls.Add(this.picFXMusic);
            this.panel2.Controls.Add(this.picBgMusic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 51);
            this.panel2.TabIndex = 16;
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = global::OGGY.Properties.Resources.close_btn_pressed;
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picExit.Location = new System.Drawing.Point(1243, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(57, 51);
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::OGGY.Properties.Resources.menu_bg;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.picNew);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFXMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBgMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFXMusic;
        private System.Windows.Forms.PictureBox picBgMusic;
        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picExit;
    }
}

