using System;
using System.Collections.Generic;

namespace PizzaBot
{
    public class BotActions
    {
        public static List<Point> ParsePoints(string points, Bound bound)
        {
            char[] delimiterChars = { ' ', ',', '(', ')' };
            string[] pointsArray = points.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            List<Point> pointsList = new();
            pointsList.Add(new Point(0, 0));
            if (!string.IsNullOrEmpty(points))
            {
                if (pointsArray.Length % 2 == 0)
                {
                    for (int i = 0; i < pointsArray.Length - 1; i += 2)
                    {
                        if (int.TryParse(pointsArray[i], out int convertedX) && int.TryParse(pointsArray[i + 1], out int convertedY))
                        {
                            if (convertedX <= bound.BoundX && convertedY <= bound.BoundY)
                            {
                                pointsList.Add(new Point(convertedX, convertedY));
                            }
                            else
                            {
                                Console.Error.WriteLine("Point '{0}' is out of bounds '{1}', '{2}'",
                                    pointsArray[i], bound.BoundX, bound.BoundY);
                                return null;
                            }
                        }
                        else
                        {
                            Console.Error.WriteLine("Attempted conversion of '{0}' failed.",
                                    pointsArray[i] ?? "<null>");
                            return null;
                        }
                    }
                }
                else
                {
                    Console.Error.WriteLine("There are odd amount of points");
                    return null;
                }
            }
            else
            {
                Console.Error.WriteLine("There are 0 points");
                return null;
            }
            return pointsList;
        }

        public static Bound ParseBound(string bound)
        {
            char[] delimiterChars = { 'x', 'X' };
            if (bound.IndexOfAny(delimiterChars) != -1)
            {
                string[] bounds = bound.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (bounds.Length == 2)
                {
                    if (int.TryParse(bounds[0], out int convertedX) && int.TryParse(bounds[1], out int convertedY))
                    {
                        return new Bound(convertedX, convertedY);
                    }
                    else
                    {
                        Console.Error.WriteLine("Attempted conversion of '{0}', '{1}' failed.",
                                bounds[0], bounds[1] ?? "<null>");
                        return null;
                    }
                }
                else
                {
                    Console.Error.WriteLine("Incorrect sizes of bounds entered.");
                    return null;
                }
            }
            else
            {
                Console.Error.WriteLine($"Invalid bound formatting: {bound}");
                return null;
            }
        }
        public static string FindPath(string move)
        {
            var tokens = move.Split(new[] { ' ' }, 2);
            Bound bound = ParseBound(tokens[0]);
            if (bound != null)
            {
                List<Point> points = ParsePoints(tokens[1], bound);

                string path = "";
                if (points != null)
                {
                    for (int item = 0; item < points.Count - 1; item++)
                    {
                        string pathFragment = FindPathFragment(points[item], points[item + 1]);
                        path += pathFragment;
                        path += "D";
                    }
                }
                else
                {
                    Console.Error.WriteLine("Points are equal to null.");
                }
                return path;
            }
            else
            {
                Console.Error.WriteLine("Bounds are equal to null.");
                return null;
            }
        }

        public static string FindPathFragment(Point currPoint, Point nextPoint)
        {
            int xDist = nextPoint.CoordX - currPoint.CoordX;
            int yDist = nextPoint.CoordY - currPoint.CoordY;
            string pathFragment = "";
            for (int x = 0; x < Math.Abs(xDist); x++)
            {
                if (xDist < 0)
                {
                    pathFragment += "W";
                }
                if (xDist > 0)
                {
                    pathFragment += "E";
                }
            }
            for (int y = 0; y < Math.Abs(yDist); y++)
            {
                if (yDist < 0)
                {
                    pathFragment += "S";
                }
                if (yDist > 0)
                {
                    pathFragment += "N";
                }
            }
            return pathFragment;
        }
    }
}
