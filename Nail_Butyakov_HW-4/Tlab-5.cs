using System;

namespace Nail_Butyakov_HW_4
{
    internal class Program
    {
        static int mxnm(int a, int b)
        {
            return Math.Max(a, b);
        }
        static void Main(string[] args)
        {

            Console.Write("Упражнение 5.1 вывод наибольшее=го из двух чисел\nВведите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольшее из двух чисел: { mxnm(a, b)}");
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
