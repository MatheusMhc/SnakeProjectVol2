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

        //private Cobra cobra = new Cobra(0, 0, Directions.DOWN);
        Game game;

        bool isKeyDown = false;

        private void SnakeProjectVol2_Load(object sender, EventArgs e)
        {
            game = new Game(tableGridGameSkane.ColumnCount, tableGridGameSkane.RowCount);

            for (int i = 0; i < tableGridGameSkane.RowCount; i++)
            {
                for (int j = 0; j < tableGridGameSkane.ColumnCount; j++)
                {
                    Panel panel = new Panel();
                    panel.Margin = new Padding(0);
                    tableGridGameSkane.Controls.Add(panel, j, i);
                }
            }
        }
        int c = 0;
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
            game.cobra.moveCobra();
            game.checkCobraAteFood();
            //if (c % 5 == 0)
            //{
            //    game.cobra.increaseCobra();
            //}
            //c++;

        }


        private void cleanGrid()
        {
            for (int i = 0; i < tableGridGameSkane.RowCount; i++)
            {
                for (int j = 0; j < tableGridGameSkane.ColumnCount; j++)
                {
                    tableGridGameSkane.GetControlFromPosition(j, i).BackColor = new Panel().BackColor;
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isKeyDown)
                return;
            isKeyDown = true;

            if (e.KeyCode == Keys.Control) return;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    game.cobra.newWave(Directions.LEFT);
                    game.cobra.moveCobra();
                    break;
                case Keys.Right:
                    game.cobra.newWave(Directions.RIGHT);
                    game.cobra.moveCobra();
                    break;
                case Keys.Up:
                    game.cobra.newWave(Directions.UP);
                    game.cobra.moveCobra();
                    break;
                case Keys.Down:
                    game.cobra.newWave(Directions.DOWN);
                    game.cobra.moveCobra();
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyDown = false;
        }
    }
}