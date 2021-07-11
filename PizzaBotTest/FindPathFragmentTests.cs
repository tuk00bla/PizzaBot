using PizzaBot;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaBotTest
{
    [TestClass]
    public class FindPathFragmentTests
    {
        [TestMethod]
        public void FindPathWithOnePoint()
        {
            var lastPoint = new Point(1, 2);

            string expected = "ENN";
            var result = BotActions.FindPathFragment(new Point(0, 0), lastPoint);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FindPathWithBothPointsOnXAxis()
        {
            var startPoint = new Point(1, 2);
            var lastPoint = new Point(1, 3);

            string expected = "N";
            var result = BotActions.FindPathFragment(startPoint, lastPoint);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindPathWithBothPointsOnYAxis()
        {
            var startPoint = new Point(2, 2);
            var lastPoint = new Point(1, 2);

            string expected = "W";
            var result = BotActions.FindPathFragment(startPoint, lastPoint);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindPathWithZeroDistance()
        {
            var startPoint = new Point(2, 2);
            var lastPoint = new Point(2, 2);

            string expected = "";
            var result = BotActions.FindPathFragment(startPoint, lastPoint);

            Assert.AreEqual(expected, result);
        }
    }
}
