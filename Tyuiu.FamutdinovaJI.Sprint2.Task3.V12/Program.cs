using Tyuiu.FamutdinovaJI.Sprint2.Task3.V12.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите значение переменной Х:                                          *");
            double x = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
 
            Console.WriteLine("Значение функции = " + res);

            Console.ReadLine();
        }
    }
}
