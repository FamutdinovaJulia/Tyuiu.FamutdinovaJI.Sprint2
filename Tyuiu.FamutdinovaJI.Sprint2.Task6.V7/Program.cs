using Tyuiu.FamutdinovaJI.Sprint2.Task6.V7.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите год:                                                            *");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите кол-во месяцев:                                                 *");
            int n = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindMonthName(m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Название месяца: " + res);

            Console.ReadLine();
        }
    }
}
