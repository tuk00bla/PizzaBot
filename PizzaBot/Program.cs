using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PizzaBot
{
    class Point
    {
        public int CoordX{ get; set; }
        public int CoordY { get; set; }

    }
    class Program
    {
            // function to find final position of
            // robot after the complete movement
        static void FinalPosition(string move)
        {   
            char[] delimiterChars = { ' ', ',', '(', ')' };
            char[] delimiterChars2 = { 'x', 'X' };
            string[] tokens = move.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                
            string[] borders = tokens[0].Split(delimiterChars2, StringSplitOptions.RemoveEmptyEntries);
                // traverse the instruction string
                // 'move'
            int xMax = Convert.ToInt32(borders[0]);
            int yMax = Convert.ToInt32(borders[1]);
            List<Point> points = new List<Point>();
            for (int i = 1; i < tokens.Length - 1; i+=2)
            {
                Point newPoint = new Point();
                newPoint.CoordX = Convert.ToInt32(tokens[i]);
                newPoint.CoordY = Convert.ToInt32(tokens[i + 1]);
                points.Add(newPoint);
            }
            for (int item = 0; item < points.Count - 1; item++)
            {
                WritePath(points[item], points[item + 1]);
                Console.Write("D");
            }
        }

        static void WritePath(Point startPoint, Point lastPoint)
         {
            int countX = lastPoint.CoordX - startPoint.CoordX;
            int countY = lastPoint.CoordY - startPoint.CoordY;
            string output = "";
            for (int x = 0; x < countX; x++)
            {
                if (countX < 0)
                {
                    output += "W";
                }
                if (countX > 0)
                {
                    output += "E";
                }
                else
                {
                    break;
                }
            }
            for (int y = 0; y < countY; y++)
            {
                if (countY < 0)
                {
                    output += "S";
                }
                if (countX > 0)
                {
                    output += "N";
                }
            }
           
            Console.WriteLine(output);
        }
            // Driver code
            public static void Main()
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    FinalPosition(line);
                }
            }
    }
}
