using Tyuiu.FamutdinovaJI.Sprint2.Task5.V9.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите день:                                                           *");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите месяц:                                                          *");
            int m = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(m,n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadLine();
        }
    }
}
