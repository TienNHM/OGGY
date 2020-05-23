using System;
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

        private void EndGame_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                this.Dispose();
        }
    }
}
