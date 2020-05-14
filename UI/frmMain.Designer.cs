namespace OGGY
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFXMusic = new System.Windows.Forms.PictureBox();
            this.pnlStars = new System.Windows.Forms.Panel();
            this.picStar03 = new System.Windows.Forms.PictureBox();
            this.picStar02 = new System.Windows.Forms.PictureBox();
            this.picStar01 = new System.Windows.Forms.PictureBox();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFXMusic)).BeginInit();
            this.pnlStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar01)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 140;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.picFXMusic);
            this.panel1.Controls.Add(this.pnlStars);
            this.panel1.Controls.Add(this.lblPlay);
            this.panel1.Controls.Add(this.lblPause);
            this.panel1.Controls.Add(this.lblQuit);
            this.panel1.Controls.Add(this.lblScores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 61);
            this.panel1.TabIndex = 2;
            // 
            // picFXMusic
            // 
            this.picFXMusic.BackColor = System.Drawing.Color.Transparent;
            this.picFXMusic.BackgroundImage = global::OGGY.Properties.Resources.opt_nomusic;
            this.picFXMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picFXMusic.Dock = System.Windows.Forms.DockStyle.Left;
            this.picFXMusic.Location = new System.Drawing.Point(281, 0);
            this.picFXMusic.Margin = new System.Windows.Forms.Padding(2);
            this.picFXMusic.Name = "picFXMusic";
            this.picFXMusic.Size = new System.Drawing.Size(70, 61);
            this.picFXMusic.TabIndex = 7;
            this.picFXMusic.TabStop = false;
            this.picFXMusic.Click += new System.EventHandler(this.picFXMusic_Click);
            // 
            // pnlStars
            // 
            this.pnlStars.Controls.Add(this.picStar03);
            this.pnlStars.Controls.Add(this.picStar02);
            this.pnlStars.Controls.Add(this.picStar01);
            this.pnlStars.Location = new System.Drawing.Point(937, 5);
            this.pnlStars.Name = "pnlStars";
            this.pnlStars.Size = new System.Drawing.Size(153, 50);
            this.pnlStars.TabIndex = 5;
            // 
            // picStar03
            // 
            this.picStar03.Dock = System.Windows.Forms.DockStyle.Left;
            this.picStar03.Image = global::OGGY.Properties.Resources.icon_super;
            this.picStar03.Location = new System.Drawing.Point(100, 0);
            this.picStar03.Name = "picStar03";
            this.picStar03.Size = new System.Drawing.Size(50, 50);
            this.picStar03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar03.TabIndex = 3;
            this.picStar03.TabStop = false;
            // 
            // picStar02
            // 
            this.picStar02.Dock = System.Windows.Forms.DockStyle.Left;
            this.picStar02.Image = global::OGGY.Properties.Resources.icon_super;
            this.picStar02.Location = new System.Drawing.Point(50, 0);
            this.picStar02.Name = "picStar02";
            this.picStar02.Size = new System.Drawing.Size(50, 50);
            this.picStar02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar02.TabIndex = 4;
            this.picStar02.TabStop = false;
            // 
            // picStar01
            // 
            this.picStar01.Dock = System.Windows.Forms.DockStyle.Left;
            this.picStar01.Image = global::OGGY.Properties.Resources.icon_super;
            this.picStar01.Location = new System.Drawing.Point(0, 0);
            this.picStar01.Name = "picStar01";
            this.picStar01.Size = new System.Drawing.Size(50, 50);
            this.picStar01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar01.TabIndex = 5;
            this.picStar01.TabStop = false;
            // 
            // lblPlay
            // 
            this.lblPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPlay.Font = new System.Drawing.Font("Bauhaus 93", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPlay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblPlay.Image = global::OGGY.Properties.Resources.btn_filter_orange;
            this.lblPlay.Location = new System.Drawing.Point(102, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(179, 61);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "PLAY";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.Visible = false;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // lblPause
            // 
            this.lblPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPause.Image = global::OGGY.Properties.Resources.pause_btn;
            this.lblPause.Location = new System.Drawing.Point(0, 0);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(102, 61);
            this.lblPause.TabIndex = 2;
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // lblQuit
            // 
            this.lblQuit.BackColor = System.Drawing.Color.Transparent;
            this.lblQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuit.Image = global::OGGY.Properties.Resources.close_btn;
            this.lblQuit.Location = new System.Drawing.Point(1235, 0);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(65, 61);
            this.lblQuit.TabIndex = 1;
            this.lblQuit.Click += new System.EventHandler(this.LblQuit_Click);
            // 
            // lblScores
            // 
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblScores.ForeColor = System.Drawing.Color.Yellow;
            this.lblScores.Image = global::OGGY.Properties.Resources.counter_bg;
            this.lblScores.Location = new System.Drawing.Point(604, -1);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(204, 63);
            this.lblScores.TabIndex = 0;
            this.lblScores.Text = "0";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oggy";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmMain_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFXMusic)).EndInit();
            this.pnlStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStar03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Panel pnlStars;
        private System.Windows.Forms.PictureBox picStar03;
        private System.Windows.Forms.PictureBox picStar02;
        private System.Windows.Forms.PictureBox picStar01;
        private System.Windows.Forms.PictureBox picFXMusic;
    }
}

