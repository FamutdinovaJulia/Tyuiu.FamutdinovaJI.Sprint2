using Tyuiu.FamutdinovaJI.Sprint2.Task4.V26.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task4.V26
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
            Console.WriteLine("* Введите значение переменной Y:                                          *");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadLine();
        }
    }
}
