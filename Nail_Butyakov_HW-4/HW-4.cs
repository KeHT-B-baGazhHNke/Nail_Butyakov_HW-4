using System;
using System.Diagnostics;
using System.Threading;

namespace HW_4
{
    internal class Program
    {
        enum vorchlvl
        {
            Хлебом_не_корми_дай_поворчать,
            Ворчит_немножко,
            Норм
        }
        struct ded
        {
            public string name;
            public vorchlvl vorch;
            public int sinyak;
            public string[] vorchwords;
            public int babka(params string[] cursedwords)
            {
                sinyak = 0;
                foreach (string word in vorchwords)
                {
                    foreach (string fck in cursedwords)
                    {
                        if (word.Contains(fck))
                            sinyak++;
                    }
                }
                return sinyak;
            }
        }
        static int arrop(ref int Refmulti, out double Outmid, params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Refmulti *= array[i];
            }

            Outmid = (double)sum / array.Length;

            return sum;
        }
        static void draw(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("###\n# #\n# #\n# #\n###");
                    break;
                case 1:
                    Console.WriteLine("  #\n  #\n  #\n  #\n  #");
                    break;
                case 2:
                    Console.WriteLine("###\n  #\n###\n#  \n###");
                    break;
                case 3:
                    Console.WriteLine("###\n  #\n###\n  #\n###");
                    break;
                case 4:
                    Console.WriteLine("# #\n# #\n###\n  #\n  #");
                    break;
                case 5:
                    Console.WriteLine("###\n#  \n###\n  #\n###");
                    break;
                case 6:
                    Console.WriteLine("###\n#  \n###\n# #\n###");
                    break;
                case 7:
                    Console.WriteLine("###\n  #\n  #\n  #\n  #");
                    break;
                case 8:
                    Console.WriteLine("###\n# #\n###\n# #\n###");
                    break;
                case 9:
                    Console.WriteLine("###\n# #\n###\n  #\n###");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Ошибка, вы ввели не цифру\n");
                    Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
            }
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задача 1 смена мест двух чисел в массиве");
                int[] array = new int[20];
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                    array[i] = rand.Next(10);
                Console.WriteLine($"Массив из 20 случайных чисел: {string.Join(" ", array)}");
                Console.Write("Введите одно из чисел данного массива: ");
                int target = Convert.ToInt32(Console.ReadLine());
                int a = Array.IndexOf(array, target);
                Console.Write("Введите еще одно из чисел данного массива: ");
                target = Convert.ToInt32(Console.ReadLine());
                int b = Array.IndexOf(array, target);
                if (a != -1 && b != -1)
                {
                    (array[a], array[b]) = (array[b], array[a]);
                    Console.WriteLine($"Полученный массив: {string.Join(" ", array)}");
                }
                else
                {
                    Console.WriteLine("Введенные числа не являются элементами массива");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\nЗадача 2 операции над массивом");
                int multi = 1;
                double mid;
                Console.WriteLine($"Сумма элементов массива: {arrop(ref multi, out mid, 1, 2, 3, 4, 5, 6, 7, 8, 9)}" +
                    $"\nПроизведение элементов массива: {multi}\nCреднее арифметическое в массиве: {mid}");
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.Write("\nЗадача 3 рисование цифр\nВведите цифру либо напишите exit или закрыть, чтобы выйти: ");
                string n0 = Console.ReadLine();
                int n;
                if (n0.ToLower() == "exit" || n0.ToLower() == "закрыть")
                    Process.GetCurrentProcess().Kill();
                try
                {
                    n = Convert.ToInt32(n0);
                    draw(n);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы ввели не цифру");
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            {
                Console.WriteLine("\nЗадача 4 Деды");
                string[] cursedwords = { "MotherF@#ker", "K@nt", "D$ck", "F@ck", "B#$tch", "F@#cking", "S@#ker", "Assh@le", "C@ckS@#ker" };

                ded Vagif = new ded();
                Vagif.name = "Vagif";
                Vagif.vorch = vorchlvl.Норм;
                string[] vagifvorchwords = { "Ekarniy babay", "Suka", "Mat' tvoyu" };
                Vagif.vorchwords = vagifvorchwords;
                Vagif.babka(cursedwords);

                ded Ruben = new ded();
                Ruben.name = "Ruben";
                Ruben.vorch = vorchlvl.Ворчит_немножко;
                string[] rubenvorchwords = { "MotherF@#ker", "K@nt", "Shegli", "Supostaty" };
                Ruben.vorchwords = rubenvorchwords;
                Ruben.babka(cursedwords);

                ded Semenych = new ded();
                Semenych.name = "Semenych";
                Semenych.vorch = vorchlvl.Хлебом_не_корми_дай_поворчать;
                string[] semenychvorchwords = { "M@nda", "S@#ker", "Assh@le", "C@ckS@#ker", "D$ck", "F@ck", "B#$tch" };
                Semenych.vorchwords = semenychvorchwords;
                Semenych.babka(cursedwords);

                ded Evlampiy = new ded();
                Evlampiy.name = "Evlampiy";
                Evlampiy.vorch = vorchlvl.Норм;
                string[] evlampiyvorchwords = { "Elki palki", "Etizhy pasatizhy", "Edrit' Kolotit'", "Egipetskaya sila" };
                Evlampiy.vorchwords = evlampiyvorchwords;
                Evlampiy.babka(cursedwords);

                ded Bombom = new ded();
                Bombom.name = "Bombom";
                Bombom.vorch = vorchlvl.Ворчит_немножко;
                string[] bombomvorchwords = { "B#$tch", "F@#cking", "S@#ker", "Net nu ti indeec ya baldyu", "ne urchy", "Nu ty frantsuz" };
                Bombom.vorchwords = bombomvorchwords;
                Bombom.babka(cursedwords);

                Console.WriteLine($"Количество фингалов у {Vagif.name}а: {Vagif.sinyak}");
                Console.WriteLine($"Количество фингалов у {Ruben.name}а: {Ruben.sinyak}");
                Console.WriteLine($"Количество фингалов у {Semenych.name}а: {Semenych.sinyak}");
                Console.WriteLine($"Количество фингалов у {Evlampiy.name}а: {Evlampiy.sinyak}");
                Console.WriteLine($"Количество фингалов у {Bombom.name}а: {Bombom.sinyak}");
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
