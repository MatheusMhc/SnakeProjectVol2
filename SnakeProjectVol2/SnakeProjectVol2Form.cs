using SnakeGameProject.Business;
using SnakeGameSpace;
using SnakeGameSpace.Business;
using SnakeProjectVol2.Business;
using SnakeProjectVol2.Properties;
using System.Drawing;

namespace SnakeProjectVol2
{
    public delegate void Notify();

    public partial class SnakeProjectVol2Form : Form
    {
        Game game;
        public event Notify loadTableComplete; 

        public SnakeProjectVol2Form()
        {
            InitializeComponent();
        }

        public SnakeProjectVol2Form(int interval)
        {
            InitializeComponent();
            timer1.Interval = interval;
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
            do
            {
                tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackColor = Color.Black;
                game.cobra = game.cobra.next;
            } while (game.cobra != null);

            game.cobra = temp;

            game.createFood();
            tableGridGameSkane.GetControlFromPosition(game.food.point.Y, game.food.point.X).BackColor = Color.Blue;

            game.moveCobra();

            if (game.youLose)
            {
                tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackColor = Color.Yellow;
                tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackgroundImage = (Image)Properties.Resources.explosionIcon;
                this.timer1.Enabled = false;
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
    }
}