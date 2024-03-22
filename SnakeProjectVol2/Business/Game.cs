using SnakeGameProject.Business;
using SnakeGameSpace.Business;

using SnakeProjectVol2.Utils;
using static System.Formats.Asn1.AsnWriter;

namespace SnakeProjectVol2.Business
{
    internal class Game
    {
        public Cobra cobra { get; set; }

        public Food food { get; set; }

        public int height { get; set; }

        public int width { get; set; }

        public bool youLose { get; set; }

        public int score { get; set; }
        public Game(int height, int width) {

            cobra = new Cobra(39, 0, Directions.DOWN);
            cobra.increaseCobra();
            cobra.increaseCobra();
            cobra.increaseCobra();
            cobra.increaseCobra();
            cobra.increaseCobra();

            this.height = height;
            this.width = width;
            this.youLose = false;
            this.score = 0;
        }

        public void createFood()
        {
            if (Util.isNotNull(food)) return;
            
            Random rn = new Random();
            int X = rn.Next(0, this.height);
            int Y = rn.Next(0, this.width);
                
            if (!cobra.contains(new Point(X, Y)))
            {
                this.food = new Food(X, Y);
                return;
            }

            createFood();
        }

        public void checkCobraAteFood()
        {
            if (Util.isNull(food)) return;

            if(cobra.contains(food.point))
            {
                this.cobra.increaseCobra();
                this.food = null;
                this.score++;
                createFood();
            }
        }

        public void checkCobraBiteItSelf()
        {

            if (Util.isNull(cobra.next)) return;

            if (cobra.next.contains(cobra.point)) this.youLose = !this.youLose;
        }


        public void changeCobraDirection(Directions direction)
        {
            if (!cobra.containsPossiblesDirection(direction)) return;                
            cobra.newWave(direction);
            moveCobra();
        }

        public void moveCobra()
        {
            cobra.moveCobra();
            checkCobraAteFood();
            checkCobraBiteItSelf();
        }

    }
}
