using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double e = 2.718;
            bool res = new bool();

            if ((y < Math.Pow(e, x)) && (y < Math.Pow(e, -x)) && (y > Math.Pow(x, 2)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
