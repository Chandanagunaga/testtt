
namespace addunittest
{
    using ConsoleApp1Applica;
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            int res;
            res = c.Add(10, 20);
            Assert.AreEqual(30, res);
        }
    }
}