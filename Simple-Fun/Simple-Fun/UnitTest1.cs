using NUnit.Framework;
namespace Simple_Fun
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var kata = new Kata();
            Assert.AreEqual("Black", kata.NotSoRandom(1, 1));
            Assert.AreEqual("White", kata.NotSoRandom(2, 1));
        }
    }

    public class Kata
    {
        public string NotSoRandom(int black, int white)
        {
            return "Black";
        }
    }
}
