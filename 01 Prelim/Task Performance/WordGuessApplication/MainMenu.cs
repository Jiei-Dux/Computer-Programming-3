using System.Data.Common;

namespace WordGuessApplication
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuessWord PLAY = new frmGuessWord();
            PLAY.Closed += (s, args) => this.Close();
            PLAY.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}