using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaBot;

namespace PizzaBotTest
{
    [TestClass]
    public class BoundsTests
    {
        [TestMethod]
        public void ParseBoundWrongNumbers()
        {
            string bound = "xX12";

            Bound expected = null;
            var result = BotActions.ParseBound(bound);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseBoundNotNumbers()
        {
            string border = "ZZxYU";

            Bound expected = null;
            var result = BotActions.ParseBound(border);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseBoundWithoutX()
        {
            string border = "12 44";

            Bound expected = null;
            var result = BotActions.ParseBound(border);

            Assert.AreEqual(expected, result);
        }
    }
}
