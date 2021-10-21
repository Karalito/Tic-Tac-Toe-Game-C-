using WindowsFormsApp1;
using NUnit.Framework;
using System.Windows.Forms;

namespace TestProject1
{
    public class StartTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_AvailableLevels()
        {
            Start start = new Start();

            Assert.AreEqual(3, start.AvailableLevels("3x3"));
            Assert.AreEqual(4, start.AvailableLevels("4x4"));
            Assert.AreEqual(5, start.AvailableLevels("5x5"));
        }

        [Test]
        public void Test_RandomXorO()
        {
            Start start = new Start();

            Assert.AreEqual(0, start.RandomXorO(0, 1));
            Assert.AreEqual(1, start.RandomXorO(1, 2));
        }

        [Test]
        public void Test_StartButton()
        {
            Start start = new Start();


        }

    }
}