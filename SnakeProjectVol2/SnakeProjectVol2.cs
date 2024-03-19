using SnakeGameProject.Business;
using SnakeGameSpace.Business;
using SnakeProjectVol2.Business;
using System.Drawing;

namespace SnakeProjectVol2
{
    public partial class SnakeProjectVol2 : Form
    {
        public SnakeProjectVol2()
        {
            InitializeComponent();
        }

        Game game;

        private void SnakeProjectVol2_Load(object sender, EventArgs e)
        {
            game = new Game(tableGridGameSkane.ColumnCount, tableGridGameSkane.RowCount);

            for (int i = 0; i < tableGridGameSkane.RowCount; i++)
            {
                for (int j = 0; j < tableGridGameSkane.ColumnCount; j++)
                {
                    Panel panel = new Panel();
                    panel.Margin = new Padding(0);
                    panel.BackColor = Color.LightGreen;
                    tableGridGameSkane.Controls.Add(panel, j, i);
                }
            }
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

            if(game.youLose)
            {
                tableGridGameSkane.GetControlFromPosition(game.cobra.point.Y, game.cobra.point.X).BackColor = Color.Yellow;
                this.timer1.Enabled = false;
            }

            
        }


        private void cleanGrid()
        {
            for (int i = 0; i < tableGridGameSkane.RowCount; i++)
            {
                for (int j = 0; j < tableGridGameSkane.ColumnCount; j++)
                {
                    if(tableGridGameSkane.GetControlFromPosition(j, i).BackColor != Color.LightGreen)
                    {
                        tableGridGameSkane.GetControlFromPosition(j, i).BackColor = Color.LightGreen;
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