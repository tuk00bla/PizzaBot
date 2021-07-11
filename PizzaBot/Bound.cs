using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBot
{
    public class Bound
    {
        public int BoundX { get; set; }
        public int BoundY { get; set; }
        public Bound(int x, int y)
        {
            BoundX = x; BoundY = y;

        }
    }
}
