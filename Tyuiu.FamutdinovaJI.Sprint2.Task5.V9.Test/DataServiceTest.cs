using Tyuiu.FamutdinovaJI.Sprint2.Task5.V9.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 2;
            int m = 4;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "03.04" ;
            Assert.AreEqual(wait, res);
        }
    }
}