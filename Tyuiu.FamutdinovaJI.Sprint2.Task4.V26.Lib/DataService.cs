using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task4.V26.Lib
{
    public class DataService : ISprint2Task4V26
    {
        public double Calculate(double x, double y)
        {
            double z = 0;
            double z1 = 0;

            if ((x - 2)<(y / 2))
            {
                z1 = 10 + (2 / (x * x));
                z = Math.Pow(z1, y);
            }
            else
            {
                z = x * x - (1 / y);
            }
            return Math.Round(z, 3);
        }
    }
}
