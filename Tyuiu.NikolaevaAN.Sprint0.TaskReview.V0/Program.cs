using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikolaevaAN.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.NikolaevaAN.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Николаева А. Н. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Обзор спринта                                                     *");
            Console.WriteLine("* Задание Review                                                          *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнила: Николаева Александра Николаевна | ПКТб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая вычисляет выражение        *");
            Console.WriteLine("* (x + y + z) * 5                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("( " + x + " + " + y + " + " + z + " ) * 5 = " + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
