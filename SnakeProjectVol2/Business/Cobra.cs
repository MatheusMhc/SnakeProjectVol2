using SnakeGameSpace.Business;
using SnakeProjectVol2.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameProject.Business
{
    internal class Cobra
    {
        public Point point { get; set; }

        public Directions diretion { get; set; }

        public Wave wave { get; set; }

        public Cobra next { get; set; }

        public Cobra(int X, int Y, Directions directions)
        {
            point = new Point(X, Y);
            diretion = directions;
            wave = null;
            next = null;
        }

        public void newWave(Directions direction)
        {
            this.wave = new Wave(direction);
        }
         
        public void transfereWave()
        {
            if(this.next != null)
            {
                this.next.wave = this.wave;
            }

            this.wave = null;
        }

        public void moveCobra(Cobra cobra)
        {
            if (cobra == null)
            {
                return;
            }

            moveCobra(cobra.next);

            if (cobra.wave != null)
            {
                cobra.diretion = cobra.wave.diretion;
                cobra.transfereWave();
            }

            switch (cobra.diretion)
            {
                case Directions.DOWN:
                    cobra.point = new Point(cobra.point.X+1, cobra.point.Y);
                    cobra.diretion = Directions.DOWN;
                    break;

                case Directions.UP:
                    cobra.point = new Point(cobra.point.X-1, cobra.point.Y);
                    cobra.diretion = Directions.UP;
                    break;

                case Directions.LEFT:
                    cobra.point = new Point(cobra.point.X, cobra.point.Y-1);
                    cobra.diretion = Directions.LEFT;
                    break;

                case Directions.RIGHT:
                    cobra.point = new Point(cobra.point.X, cobra.point.Y+1);
                    cobra.diretion = Directions.RIGHT;
                    break;
            }
           
        }

        public Cobra newTail(Cobra cobra)
        {
            Cobra tail;
            switch (cobra.diretion)
            {
                case Directions.DOWN:
                    tail = new Cobra(cobra.point.X - 1, cobra.point.Y, cobra.diretion);
                    break;

                case Directions.UP:
                    tail = new Cobra(cobra.point.X + 1, cobra.point.Y, cobra.diretion);
                    break;

                case Directions.LEFT:
                    tail = new Cobra(cobra.point.X, cobra.point.Y + 1, cobra.diretion);
                    break;

                default:
                    tail = new Cobra(cobra.point.X, cobra.point.Y-1, cobra.diretion);
                    break;
            }

            return tail;
        }

        public void increaseCobra(Cobra cobra)
        {
            if (cobra.next == null)
            {
                cobra.next = newTail(cobra);
                return;
            }

            increaseCobra(cobra.next);
        }

    }
}
