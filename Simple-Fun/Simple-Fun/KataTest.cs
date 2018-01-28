using NUnit.Framework;
namespace Simple_Fun
{
    [TestFixture]
    public class KataTest
    {
        [Test]
        public void Test()
        {
            var kata = new Kata();
            Assert.AreEqual("Black", kata.NotSoRandom(1, 1));
            Assert.AreEqual("White", kata.NotSoRandom(2, 1));

            Assert.AreEqual("Black", kata.NotSoRandom(1, 2));

            Assert.AreEqual("White", kata.NotSoRandom(2, 2));

            Assert.AreEqual("White", kata.NotSoRandom(6, 9));

            Assert.AreEqual("White", kata.NotSoRandom(10000, 10000));

            Assert.AreEqual("Black", kata.NotSoRandom(11111, 22222));
        }
    }
}
