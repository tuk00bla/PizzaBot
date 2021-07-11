using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBot;
namespace PizzaBotTest
{

    [TestClass]
    public class FindPathTests
    {
        [TestMethod]
        public void ParseNotNullPoints()
        {
            string points = "(2, 4) (3, 1) (4, 4), (0, 0)";
            Bound exampleBound = new(5, 5);

            string expected = "EENNNNDESSSDENNNDWWWWSSSSD";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseNotNullPoints2()
        {
            string points = "(0, 0) (3, 1) ";
            Bound exampleBound = new(5, 5);

            string expected = "EENNNNDESSSDENNNDWWWWSSSSD";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }
    }
}
