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
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblQuit);
            this.panel1.Controls.Add(this.lblScores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 75);
            this.panel1.TabIndex = 2;
            // 
            // lblQuit
            // 
            this.lblQuit.BackColor = System.Drawing.Color.Transparent;
            this.lblQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuit.Image = global::OGGY.Properties.Resources.close_btn;
            this.lblQuit.Location = new System.Drawing.Point(1213, 0);
            this.lblQuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(87, 75);
            this.lblQuit.TabIndex = 1;
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // lblScores
            // 
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblScores.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblScores.ForeColor = System.Drawing.Color.Yellow;
            this.lblScores.Image = global::OGGY.Properties.Resources.counter_bg;
            this.lblScores.Location = new System.Drawing.Point(0, 0);
            this.lblScores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(199, 75);
            this.lblScores.TabIndex = 0;
            this.lblScores.Text = "0";
            this.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "đa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmMain_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Panel panel1;
    }
}

