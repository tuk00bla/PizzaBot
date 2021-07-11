using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBot;
using System.Collections.Generic;

namespace PizzaBotTest
{
    [TestClass]
    public class PointsTests
    {
        [TestMethod]
        public void ParsePointsBiggerThanBounds()
        {
            string points = "(2, 4) (3, 1) (50, 50), (0, 0)";
            Bound exampleBound = new(5, 5);

            List<Point> expected = null;
            var result = BotActions.ParsePoints(points, exampleBound);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseZeroPoints()
        {
            string points = "";
            Bound exampleBound = new(5, 5);

            List<Point> expected = null;
            var result = BotActions.ParsePoints(points, exampleBound);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseWithNotNullPoints()
        {
            string points = "(2, 4) (3, 1) (1, 1), (0, 0)";
            Bound exampleBound = new(5, 5);

            var expected = new List<Point>() { new Point(0, 0), new Point(2, 4), new Point(3, 1), new Point(1, 1), new Point(0, 0) };
            List<Point> result = BotActions.ParsePoints(points, exampleBound);
            for (int i = 0; i < result.Count; i++)     
            {
                Assert.AreEqual(expected[i].CoordX, result[i].CoordX);
                Assert.AreEqual(expected[i].CoordY, result[i].CoordY);
            }
        }
    }
}
