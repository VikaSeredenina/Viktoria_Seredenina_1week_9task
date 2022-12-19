using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_9._1
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            int i;
            int n;

            while (true)
            {
                try
                {
                    Console.WriteLine("Сколько чисел будем вводить: ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
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


            double[] mass = new double[n];
            Console.WriteLine("Введите строку чисел: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("mass[{0}]: ", i);
                mass[i] = double.Parse(Console.ReadLine());
            }

            //Диапазон
            Console.WriteLine("Введите начало диапазона:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона:");
            double B = double.Parse(Console.ReadLine());
            if (A>B)
            {
                Console.WriteLine("Начало диапазона не может быть больше конца:");
                return;
            }
            
            
            
            // запись в файл dat
            FileStream f = new FileStream("out.dat", FileMode.OpenOrCreate);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int j = 0; j < n; j++)
            {
                fOut.Write(mass[j] );
            }

            fOut.Close();

            //запись из dat в txt
            f = new FileStream("out.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            StreamWriter sw = new StreamWriter(File.Open("out.txt", FileMode.Create), Encoding.UTF8);
           
          
            // считываем каждое значение из файла
            double a;
            while (fIn.PeekChar() > -1)
            {
                a = Math.Round(fIn.ReadDouble(),2);
                
                    sw.Write(a + " ");
            }


            fIn.Close();
            sw.Close();
            f.Close();

            // запись из файла в консоль
            StreamReader sr = new StreamReader("out.txt");
            string s = sr.ReadLine();
            sr.Close();
            string[] text = s.Split(' ');
            double[] array = new double[text.Length];
            for (int j = 0; j < array.GetLength(0)-1; j++)
            {
                array[j] = double.Parse(text[j]);
                if (!(array[j]>=A && array[j]<=B))
                    Console.Write(array[j] + " ");
            }

            
         
        }
    }
}

