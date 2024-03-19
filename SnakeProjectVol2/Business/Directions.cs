using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeProjectVol2.Business;
using SnakeProjectVol2.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SnakeGameSpace.Business
{
    enum Directions
    {
        [ChangingDirections(new Directions[] {Directions.RIGHT,Directions.LEFT})]
        UP,

        [ChangingDirections(new Directions[] { Directions.LEFT, Directions.RIGHT })]
        DOWN,

        [ChangingDirections(new Directions[] { Directions.UP, Directions.DOWN })]
        LEFT,

        [ChangingDirections(new Directions[] { Directions.UP, Directions.DOWN })]
        RIGHT
    }

}
