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

        public bool wasEaten(Stack<Point> snake)
        {
            bool check = false;
            foreach (var item in snake)
            {
                if (item.X == point.X && item.Y == point.Y) check = true; continue;
                
            }
            return check;
        }
    }

    
}
