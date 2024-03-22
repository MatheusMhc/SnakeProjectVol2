
using SnakeProjectVol2;

namespace SnakeGameSpace
{
    public partial class Menu : FormMethods
    {
        public Menu()
        {
            InitializeComponent();
            lblEasy.Visible = false;
            lblMedium.Visible = false;
            lblHard.Visible = false;
            lblBack.Visible = false;
            loadingProgress.Visible = false;
        }

        public override void startFresh()
        {
            this.Show();
            enableDisableLabels(true);
            loadingProgress.Visible = false;
        }

        private void lblNewGame_MouseMove(object sender, MouseEventArgs e)
        {
            lblNewGame.ForeColor = Color.Gray;
        }

        private void lblNewGame_MouseLeave(object sender, EventArgs e)
        {
            lblNewGame.ForeColor = Color.White;
        }

        private void lblExit_MouseMove(object sender, MouseEventArgs e)
        {
            lblExit.ForeColor = Color.Gray;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;
        }

        private void lblAbout_MouseLeave(object sender, EventArgs e)
        {
            lblAbout.ForeColor = Color.White;
        }

        private void lblAbout_MouseMove(object sender, MouseEventArgs e)
        {
            lblAbout.ForeColor = Color.Gray;
        }

        private void lblNewGame_MouseClick(object sender, MouseEventArgs e)
        {
            selectSoundGame("../../../resources/option.wav");
            enableDisableLabels(false);
        }

        private void lblEasy_MouseMove(object sender, MouseEventArgs e)
        {
            lblEasy.ForeColor = Color.Gray;
        }

        private void lblEasy_MouseLeave(object sender, EventArgs e)
        {
            lblEasy.ForeColor = Color.White;
        }

        private void lblMedium_MouseMove(object sender, MouseEventArgs e)
        {
            lblMedium.ForeColor = Color.Gray;
        }

        private void lblMedium_MouseLeave(object sender, EventArgs e)
        {
            lblMedium.ForeColor = Color.White;
        }

        private void lblHard_MouseMove(object sender, MouseEventArgs e)
        {
            lblHard.ForeColor = Color.Gray;
        }

        private void lblHard_MouseLeave(object sender, EventArgs e)
        {
            lblHard.ForeColor = Color.White;
        }

        private void Form2_Shown(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblHard_Click(object sender, EventArgs e)
        {
            selectSoundGame("../../../resources/option.wav");
            newGame(this.loadingProgress, 50);
        }

        private void lblMedium_Click(object sender, EventArgs e)
        {
            selectSoundGame("../../../resources/option.wav");
            newGame(this.loadingProgress, 150);
        }

        private void lblEasy_Click(object sender, EventArgs e)
        {
            selectSoundGame("../../../resources/option.wav");
            newGame(this.loadingProgress, 250);
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.White;
        }

        private void lblBack_MouseMove(object sender, MouseEventArgs e)
        {
            lblBack.ForeColor = Color.Gray;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            selectSoundGame("../../../resources/option.wav");
            enableDisableLabels(true);
        }

        private void enableDisableLabels(bool value)
        {
            enableFirsScreenLabels(value);
            enableLevelLabels(!value);
        }

        private void enableFirsScreenLabels(bool value)
        {
            lblNewGame.Visible = value;
            lblAbout.Visible = value;
            lblExit.Visible = value;
        }

        private void enableLevelLabels(bool value)
        {
            lblEasy.Visible = value;
            lblMedium.Visible = value;
            lblHard.Visible = value;
            lblBack.Visible = value;
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            selectSoundGame("../../../resources/option.wav");
            enableFirsScreenLabels(false);
            lblBack.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
