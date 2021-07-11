using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBot;
namespace PizzaBotTest
{

    [TestClass]
    public class FindPathTests
    {
        [TestMethod]
        public void ParsePoints()
        {
            string points = "(2, 4) (3, 1) (4, 4), (0, 0)";
            Bound exampleBound = new(5, 5);

            string expected = "EENNNNDESSSDENNNDWWWWSSSSD";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseZeroPoints()
        {
            string points = "";
            Bound exampleBound = new(5, 5);

            Point expected = null;
            var result = BotActions.ParsePoints(points, exampleBound);

            Assert.AreEqual(expected, result);
        }
    }
}
