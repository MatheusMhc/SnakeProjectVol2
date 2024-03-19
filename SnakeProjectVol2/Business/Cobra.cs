using SnakeGameSpace.Business;
using SnakeProjectVol2.Business;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameProject.Business
{
    internal class Cobra
    {


        private readonly int MAX_X = int.Parse(ConfigurationManager.AppSettings["maxX"]);

        private readonly int MAX_Y = int.Parse(ConfigurationManager.AppSettings["maxX"]);

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

        public void moveCobra()
        {
            if (this.next != null)
            {
                this.next.moveCobra();
            }

            if (this.wave != null)
            {
                this.diretion = this.wave.diretion;
                this.transfereWave();
            }

            switch (this.diretion)
            {
                case Directions.DOWN:
                    this.point = new Point(addX(), this.point.Y);
                    this.diretion = Directions.DOWN;
                    break;

                case Directions.UP:
                    this.point = new Point(subtractX(), this.point.Y);
                    this.diretion = Directions.UP;
                    break;

                case Directions.LEFT:
                    this.point = new Point(this.point.X, subtractY());
                    this.diretion = Directions.LEFT;
                    break;

                case Directions.RIGHT:
                    this.point = new Point(this.point.X, addY());
                    this.diretion = Directions.RIGHT;
                    break;
            }

        }

        public Cobra newTail()
        {
            Cobra tail;
            switch (this.diretion)
            {
                case Directions.DOWN:
                    tail = new Cobra(this.point.X - 1, this.point.Y, this.diretion);
                    break;

                case Directions.UP:
                    tail = new Cobra(this.point.X + 1, this.point.Y, this.diretion);
                    break;

                case Directions.LEFT:
                    tail = new Cobra(this.point.X, this.point.Y + 1, this.diretion);
                    break;

                default:
                    tail = new Cobra(this.point.X, this.point.Y-1, this.diretion);
                    break;
            }

            return tail;
        }

        public void increaseCobra()
        {
            if (this.next == null)
            {
                this.next = this.newTail();
                return;
            }

            this.next.increaseCobra();
        }

        public bool containsDirection(Directions direction)
        {
            return this.diretion.GetAttribute<ChangingDirections>().directions.ToList().Contains(direction);
        }

        public bool contains(Point point)
        {
            if (this.next != null)
            {
                this.next.contains(point);
            }

            if (this.point.X == point.X && this.point.Y == point.Y)
            {
                return true;
            }
            
            return false;

        }

        private int addX()
        {
            int xval = this.point.X + 1;
            if (xval >= MAX_X) xval = 0;
            return xval;
        }

        private int addY()
        {
            int yval = this.point.Y + 1;
            if (yval >= MAX_Y) yval = 0;
            return yval;
        }

        private int subtractX()
        {
            int xval = this.point.X - 1;
            if (xval < 0) xval = MAX_X - 1;
            return xval;
        }

        private int subtractY()
        {
            int yval = this.point.Y - 1;
            if (yval < 0) yval = MAX_Y - 1;
            return yval;
        }

    }
}
