using Tyuiu.FamutdinovaJI.Sprint2.Task6.V7.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            string res = ds.FindMonthName(1990, 2);
            Assert.AreEqual(res, "март");
        }
    }
}