using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameSpace.Business
{
    internal class Food
    {
        public Point point { get; set; }
        

        public Food(int maximumX, int maximumY)
        {
            this.point = new Point(maximumX, maximumY);
        }
    }

    
}
