using SnakeGameProject.Business;
using SnakeGameSpace.Business;
using System.Drawing;

namespace SnakeProjectVol2
{
    public partial class SnakeProjectVol2 : Form
    {
        public SnakeProjectVol2()
        {
            InitializeComponent();
        }

        private Cobra cobra = new Cobra(0,0,Directions.DOWN);
        bool isKeyDown = false;

        private void SnakeProjectVol2_Load(object sender, EventArgs e)
        {
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
            Cobra temp = cobra;
            do
            {
                tableGridGameSkane.GetControlFromPosition(cobra.point.Y, cobra.point.X).BackColor = Color.Black;
                cobra = cobra.next;
            } while (cobra != null);

            cobra = temp;

            cobra.moveCobra(cobra);
            if(c  == 5 || c==6)
            {
                cobra.increaseCobra(cobra);
            }
            c++;

            cobra.test(cobra);
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
                    cobra.diretion = Directions.LEFT;
                    cobra.newWave();
                    break;
                case Keys.Right:
                    cobra.diretion = Directions.RIGHT;
                    cobra.newWave();
                    break;
                case Keys.Up:
                    cobra.diretion = Directions.UP;
                    cobra.newWave();
                    break;
                case Keys.Down:
                    cobra.diretion = Directions.DOWN;
                    cobra.newWave();
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyDown = false;
        }
    }
}