using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y = 0;
            double y1 = 0;
            double y2 = 0;

            if (x > 1)
            {
                y1 = (x + 1) / (x - 1);
                y2 = Math.Pow(y1, x);
                y = x + y2;
            }
            else if (x == 0)
            {
                y1 = Math.Sqrt(x + 1);
                y2 = Math.Cos(y1);
                y = 1 + y2;
            }
            else if ((-16 < x) && (x < 2))
            {
                y1 = 5 / (x * x);
                y2 = 7 + y1;
                y = Math.Pow(y2, x);
            }
            else if (x < -16)
            {
                y = x + (10 * x) - (1 / x);
            }
            return Math.Round(y, 3);
        }
    }
}
