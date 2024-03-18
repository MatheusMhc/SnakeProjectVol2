using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGameProject.Business;
using SnakeGameSpace.Business;

namespace SnakeProjectVol2.Business
{
    internal class Game
    {
        public Cobra cobra { get; set; }

        public Food food { get; set; }

        public int height { get; set; }

        public int width { get; set; }

        public bool isFoodCreated { get; set; }
        
        public Game(int height, int width) {

            cobra = new Cobra(0, 0, Directions.DOWN);
            this.height = height;
            this.width = width;
        }

        public void createFood()
        {

            if (!this.isFoodCreated)
            {
                Random rn = new Random();
                int X = rn.Next(0, this.height);
                int Y = rn.Next(0, this.width);
                

                if (!cobra.contains(new Point(X, Y)))
                {
                    this.food = new Food(X, Y);
                    this.isFoodCreated = true;
                    return;
                }

                this.food = null;
                this.isFoodCreated = false;

            }

        }

        public void checkCobraAteFood()
        {
            if (!isFoodCreated) return;

            if(cobra.contains(food.point))
            {
                this.cobra.increaseCobra();
                this.food = null;
                this.isFoodCreated = false;

                createFood();
            }
        }

        public void changeCobraDirection(Directions direction)
        {
            cobra.newWave(direction);
        }

        public void moveCobra()
        {
            cobra.moveCobra();
            checkCobraAteFood();  
        }

    }
}
