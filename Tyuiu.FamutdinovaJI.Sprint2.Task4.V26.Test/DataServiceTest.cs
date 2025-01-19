using Tyuiu.FamutdinovaJI.Sprint2.Task4.V26.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 12155.062;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 8.5;
            Assert.AreEqual(wait, res);
        }

    }
}