using Tyuiu.FamutdinovaJI.Sprint2.Task7.V5.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите X:                                                              *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                              *");
            double y = Convert.ToDouble(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
