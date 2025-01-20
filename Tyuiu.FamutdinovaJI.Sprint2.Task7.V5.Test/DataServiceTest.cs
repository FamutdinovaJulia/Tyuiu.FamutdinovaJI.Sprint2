using Tyuiu.FamutdinovaJI.Sprint2.Task7.V5.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, true);
        }
    }
}