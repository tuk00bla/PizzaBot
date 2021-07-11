using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBot;

namespace PizzaBotTest
{

    [TestClass]
    public class FindPathTests
    {
        [TestMethod]
        public void FindPathWithNotNullPoints()
        {
            string points = "4x4 (2, 4) (3, 1) (4, 4), (0, 0)";

            string expected = "EENNNNDESSSDENNNDWWWWSSSSD";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindPathWithTwoEqualPoints()
        {
            string points = "4x4 (2, 4) (2, 4)";

            string expected = "EENNNNDD";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindPathWithZeroDistance()
        {
            string points = "4x4 (0, 0) (0, 0)";

            string expected = "DD";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindPathWithOnePoint()
        {
            string points = "5x5 (0, 0)";

            string expected = "D";
            var result = BotActions.FindPath(points);

            Assert.AreEqual(expected, result);
        }
    }
}
