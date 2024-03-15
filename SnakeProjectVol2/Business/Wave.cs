using SnakeGameSpace.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeProjectVol2.Business
{
    internal class Wave
    {
        public Point point { get; set; }

        public Directions diretion { get; set; }

        public Wave(int X, int Y, Directions directions)
        {
            this.point = new Point(X, Y);
            this.diretion = directions;
        }
    }
}
