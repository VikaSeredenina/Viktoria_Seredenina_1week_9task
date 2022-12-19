using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadania_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k1, k2;
            while (true)
            {
                try
                {
                    Console.Write("Введите k1 ");
                    k1 = int.Parse(Console.ReadLine());
                    if (k1 <= 0)
                    {
                        Console.WriteLine("Введите целое число больше 0");
                        continue;

                    }
                    else
                    {
                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("Некорректные данные");

                }
            }
            while (true)
            {
                try
                {
                    Console.Write(" Введите k2 ");
                    k2 = int.Parse(Console.ReadLine());

                    if (k2 <= 0)
                    {
                        Console.WriteLine("Введите целое число больше 0");
                        continue;

                    }
                    else
                    {
                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("Некорректные данные");

                }
            }
            if (k1 > k2)
            {
                Console.WriteLine("k1 не может быть больше k2");
                return;
            }

            using (StreamReader sr = new StreamReader("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\9 задание\\zad9.2.txt"))
            {
                string line;

                while (true)
                {
                    line = sr.ReadLine(); // считываем из файла весь текст

                    if (line == null) break;

                    for (int i = k1 - 1; i <= k2 - 1; i++)
                        Console.Write(line[i]);
                    Console.WriteLine();
                }
            }

        }
    }
}

            