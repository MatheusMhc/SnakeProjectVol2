
using NAudio.Wave;
using SnakeProjectVol2;
using SnakeProjectVol2.Business;
using System.Windows.Forms;

namespace SnakeGameSpace
{
    public partial class Menu : Form
    {

        WaveOut soundPlayer = new WaveOut();

        public Menu()
        {
            InitializeComponent();
            //selectSoundGame("../../../resources/menusound.wav");
            lblEasy.Visible = false;
            lblMedium.Visible = false;
            lblHard.Visible = false;
            lblBack.Visible = false;
            loadingProgress.Visible = false;
        }

        private void selectSoundGame(string name)
        {
            AudioFileReader sound = new AudioFileReader(name);
            soundPlayer.Init(sound);
            soundPlayer.Play();
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
            //selectSoundGame("../../../resources/game-start-6104.wav");
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

        private void newGame(int interval)
        {
            //var gameScreen = new SnakeProjectVol2.SnakeProjectVol2Form(this, interval);
            //gameScreen.Show();


            var gameScreen = new SnakeProjectVol2.SnakeProjectVol2Form(interval);

            this.loadingProgress.Visible = true;
            gameScreen.loadTableComplete += () => openNewForm(gameScreen) ;
            gameScreen.loadPanelOnGrid(this.loadingProgress);
            gameScreen.Closed += (s, arg) => this.Close();

        }
        public void openNewForm(SnakeProjectVol2Form gameScreen)
        {
            this.Hide();
            gameScreen.Show();

        }

        private void Form2_Shown(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblHard_Click(object sender, EventArgs e)
        {
            //selectSoundGame("../../../resources/game-start-6104.wav");
            newGame(50);
        }

        private void lblMedium_Click(object sender, EventArgs e)
        {
            //selectSoundGame("../../../resources/game-start-6104.wav");
            newGame(150);
        }

        private void lblEasy_Click(object sender, EventArgs e)
        {
            //selectSoundGame("../../../resources/game-start-6104.wav");
            newGame(250);
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
            //selectSoundGame("../../../resources/game-start-6104.wav");
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
            //selectSoundGame("../../../resources/game-start-6104.wav");
            enableFirsScreenLabels(false);
            lblBack.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
