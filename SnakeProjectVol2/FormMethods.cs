
using NAudio.Wave;

namespace SnakeProjectVol2
{
    public abstract class FormMethods : Form
    {
        protected WaveOut soundPlayer = new WaveOut();

        public abstract void startFresh();

        protected void selectSoundGame(string name)
        {
            AudioFileReader sound = new AudioFileReader(name);
            soundPlayer.Init(sound);
            soundPlayer.Play();
        }

        protected void newGame(ProgressBar loadingProgress, int interval)
        {
            string dirName = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
            
            selectSoundGame(dirName + "\\Resources\\residentcobra.wav");
            var gameScreen = new SnakeProjectVol2Form(interval);

            loadingProgress.Visible = true;
            gameScreen.loadTableComplete += () => openNewForm(gameScreen);
            gameScreen.loadPanelOnGrid(loadingProgress);
            gameScreen.Closed += (s, arg) => this.startFresh();

        }

        protected void openNewForm(SnakeProjectVol2Form gameScreen)
        {
            this.Hide();
            gameScreen.Show();
        }

    }
}
