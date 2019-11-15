using System;
using System.Collections.Generic;

namespace _1._3_Massive_Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,max,min;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите разъем массива:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите минимум:");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите максимум:");
                    max = Convert.ToInt32(Console.ReadLine());
                    if (min > max) throw new ArgumentNullException();
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Random rnd = new Random();
            List<int> l = new List<int>(x);
            for (int i = 0; i < x; i++)
            {
                l.Add(rnd.Next(min,max));
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write(l[i].ToString() + " ");
            }
        }
    }
}
