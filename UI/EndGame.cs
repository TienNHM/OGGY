﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGGY
{
    public partial class EndGame : Form
    {
        public EndGame(int scores)
        {
            InitializeComponent();
            lblScores.Text = scores.ToString().Trim();
            if (scores > frmMenu.iHighScore)
            {
                frmMenu.iHighScore = scores;
                lblHighScores.Visible = true;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
