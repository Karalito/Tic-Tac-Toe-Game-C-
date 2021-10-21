using GameApp;
using NUnit.Framework;

namespace TicTacTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAvailableLevel3x3()
        {
            Start start = new Start();

            Assert.AreEqual(3, start.AvailableLevels("3x3"));
        }
    }
}