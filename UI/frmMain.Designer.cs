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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oggy";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmMain_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblPlay;
    }
}

