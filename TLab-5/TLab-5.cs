using System;

namespace Nail_Butyakov_HW_4
{
    internal class Program
    {
        static int mxnm(int a, int b)
        {
            return Math.Max(a, b);
        }
        static void swap(ref int refa, ref int refb)
        {
            (refa, refb) = (refb, refa);
            Console.WriteLine($"Теперь первое число это: {refa}\nВторое число это: {refb}");
        }
        static bool fakt(int f)
        {
            try
            {
                checked
                {
                    if (f == 0)
                    {
                        Console.WriteLine($"Факториал введенного числа: 1");
                    }
                    else if (f < 0)
                    {
                        Console.WriteLine($"Вы ввели отрицательное число, а я не умею считать факториал отрицательного числа, в следующий раз вводите положительное число пж");
                    }
                    else
                    {
                        for (int i = f - 1; i > 1; i--)
                        {
                            f = f * i;
                        }
                        Console.WriteLine($"Факториал введенного числа: {f}");
                    }
                }
                return true;
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Произошло переполнение...");
                return false;
            }

        }
        static int faktrec(int f)
        {
            if (f == 1 || f == 0)
            {
                return 1;
            }
            else
            {
                return f * faktrec(f - 1);
            }
        }
        static int NOD(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                while (a != 0 && b != 0)
                {
                    if (Math.Abs(a) > Math.Abs(b))
                        a = a % b;
                    else
                        b = b % a;
                }
                return a + b;
            }
            else
                return a + b;
        }
        static int NOD(int a, int b, int c)
        {
            if ((a != 0 && b != 0 && c != 0))
                return NOD(NOD(a, b), c);
            else
                return a + b + c;
        }
        static int fib(int n)
        {
            int[] array = new int[100];
            if (n <= 1)
            {
                return 1;
            }
            else if (array[n] != 0)
            {
                return array[n];
            }
            array[n] = fib(n - 2) + fib(n - 1);
            return array[n];
        }

        static void Main(string[] args)
        {
            {
                Console.Write("Упражнение 5.1 вывод наибольшее=го из двух чисел\nВведите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Наибольшее из двух чисел: {mxnm(a, b)}");
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nУпражнение 5.2 обмен значений переменных\nВведите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                swap(ref a, ref b);
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nУпражнение 5.3 нахождение факториала\nВведите целое неотрицательное число: ");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{fakt(f)}\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nУпражнение 5.4 нахождение факториала рекурсией\nВведите целое неотрицательное число: ");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Факториал введенного числа: {faktrec(f)}\n\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nДомашнее задание 5.1 НОД для 2 чисел\nВведите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"НОД для {a} и {b} это: {NOD(a, b)}");
                Console.Write("\nНОД для 3 чисел\nВведите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите третье число: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"НОД для {a}, {b} и {c} это: {NOD(a, b, c)}");
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nДомашнее задание 5.2 числа Фибоначчи\nВведите порядковый номер числа из ряда Фибоначчи:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{n}-ым числом в ряде Фибоначчи является: {fib(n)}\n\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
