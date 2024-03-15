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
        public Directions diretion { get; set; }

        public Wave(Directions directions)
        {
            this.diretion = directions;
        }
    }
}
