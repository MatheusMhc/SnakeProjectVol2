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

        public void newWave()
        {
            this.wave = new Wave(this.point.X, this.point.Y, this.diretion);
        }

        public void test(Cobra cobra)
        {
            if (cobra == null)
            {
                return;
            }

            test(cobra.next);

            if(cobra.wave != null) {
                cobra.next.wave = wave;
                cobra.wave = null;
            }
        }

        public void moveCobra(Cobra cobra)
        {
            if (cobra == null)
            {
                return;
            }

            if(cobra.wave != null)
            {
                switch (cobra.wave.diretion)
                {
                    case Directions.DOWN:
                        cobra.point = new Point(cobra.wave.point.X + 1, cobra.wave.point.Y);
                        break;

                    case Directions.UP:
                        cobra.point = new Point(cobra.wave.point.X - 1, cobra.wave.point.Y);
                        break;

                    case Directions.LEFT:
                        cobra.point = new Point(cobra.wave.point.X, cobra.wave.point.Y - 1);
                        break;

                    case Directions.RIGHT:
                        cobra.point = new Point(cobra.wave.point.X, cobra.wave.point.Y + 1);
                        break;
                }

                return;
            }

            switch (cobra.diretion)
            {
                case Directions.DOWN:
                    cobra.point = new Point(cobra.point.X+1, cobra.point.Y);
                    break;

                case Directions.UP:
                    cobra.point = new Point(cobra.point.X-1, cobra.point.Y);
                    break;

                case Directions.LEFT:
                    cobra.point = new Point(cobra.point.X, cobra.point.Y-1);
                    break;

                case Directions.RIGHT:
                    cobra.point = new Point(cobra.point.X, cobra.point.Y+1);
                    break;
            }

            moveCobra(cobra.next);
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
