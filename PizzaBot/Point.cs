using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBot
{
    public class Point
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Point(int x, int y)
        {
            CoordX = x; CoordY = y;

        }
    }
}
