using SnakeGameProject.Business;
using SnakeGameSpace.Business;
using SnakeProjectVol2.Business;

namespace SnakeProjectVol2
{
    public delegate void Notify();

    public partial class SnakeProjectVol2Form : FormMethods
    {
        public event Notify loadTableComplete;

        Game game;

        public SnakeProjectVol2Form()
        {
            InitializeComponent();
        }

        public SnakeProjectVol2Form(int interval)
        {
            InitializeComponent();
            timer1.Interval = interval;
            this.loadingProgress.Visible = false;
            this.picBoxYouDead.Visible = false;
        }
        public override void startFresh()
        {
            this.Close();
        }

        public void SnakeProjectVol2_Load(object sender, EventArgs e)
        {
            game = new Game(tableGridGameSkane.ColumnCount, tableGridGameSkane.RowCount);
        }

        public void loadPanelOnGrid(ProgressBar bar)
        {
            for (int i = 0; i < tableGridGameSkane.RowCount; i++)
            {
                for (int j = 0; j < tableGridGameSkane.ColumnCount; j++)
                {
                    Panel panel = new Panel();
                    panel.Margin = new Padding(0);
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    tableGridGameSkane.Controls.Add(panel, j, i);
                }

                bar.PerformStep();
            }

            loadTableComplete?.Invoke();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cleanGrid();
            Cobra temp = game.cobra;

            try
            {
                do
                {
                    tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackColor = Color.Black;
                    game.cobra = game.cobra.next;
                } while (game.cobra != null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            game.cobra = temp;

            game.createFood();
            tableGridGameSkane.GetControlFromPosition(game.food.point.Y, game.food.point.X).BackColor = Color.Blue;
            lblScoreValue.Text = game.score.ToString();
            game.moveCobra();

            if (game.youLose)
            {
                tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackColor = Color.Yellow;
                tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackgroundImage = (Image)Properties.Resources.explosionIcon;
                this.timer1.Enabled = false;
                this.grpBoxScore.Visible = false;
                this.picBoxYouDead.Visible = true;
                this.lblDoYouContinue.Visible = true;
                this.lblYes.Visible = true;
                this.lblNo.Visible = true;
            }

        }


        private void cleanGrid()
        {
            for (int i = 0; i < tableGridGameSkane.RowCount; i++)
            {
                for (int j = 0; j < tableGridGameSkane.ColumnCount; j++)
                {
                    if (tableGridGameSkane.GetControlFromPosition(j, i).BackColor != Color.LightGreen)
                    {
                        tableGridGameSkane.GetControlFromPosition(j, i).BackColor = Color.LightGreen;
                        tableGridGameSkane.GetControlFromPosition(j, i).BackgroundImage = null;
                    }
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    game.changeCobraDirection(Directions.LEFT);
                    break;
                case Keys.Right:
                    game.changeCobraDirection(Directions.RIGHT);
                    break;
                case Keys.Up:
                    game.changeCobraDirection(Directions.UP);
                    break;
                case Keys.Down:
                    game.changeCobraDirection(Directions.DOWN);
                    break;
            }
        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            newGame(this.loadingProgress, timer1.Interval);
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}