using Tyuiu.FamutdinovaJI.Sprint2.Task1.V27.Lib;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Фамутдинова Ю. И. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Фамутдинова Юлия Ильфатовна | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать,но использовать один раз в          *");
            Console.WriteLine("* выражении) но использовать один раз в выражении) и логических операций  *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
            Console.WriteLine("* последовательность(массив): (False, False, True, False, True, False),   *");
            Console.WriteLine("* при a = 654, b = 325, c = 154, d = 333.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 654                                                                 *");
            Console.WriteLine("* b = 325                                                                 *");
            Console.WriteLine("* c = 154                                                                 *");
            Console.WriteLine("* d = 333                                                                 *");
            Console.WriteLine("*                                                                         *");

            int a = 654;
            int b = 325;
            int c = 154;
            int d = 333;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
