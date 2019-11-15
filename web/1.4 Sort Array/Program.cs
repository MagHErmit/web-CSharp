using System;
using System.Collections.Generic;

namespace _1._4_Sort_Array
{
    class Program
    {
        static void Print(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i].ToString() + " ");
            }
        }
        static void BubbleSort(ref List<int> a, Func<int, int, bool> comp)
        {
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = a.Count - 1; j > i; j--)
                {
                    if (comp(a[j], a[j - 1]))
                    {
                        int temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            int x, max, min, flag;
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
                    if (min > max) throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("1 - От большего к меньшему\n2 - От меньшего к большему");
                    flag = Convert.ToInt32(Console.ReadLine());
                    if (!(flag == 1 || flag == 2)) throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }

            Random rnd = new Random();
            List<int> l = new List<int>();
            for (int i = 0; i < x; i++)
            {
                l.Add(rnd.Next(min, max));
            }
            Console.WriteLine("Массив до:");

            Print(l);

            if(flag == 1)
                BubbleSort(ref l, (a, b) => a > b);
            else
                BubbleSort(ref l, (a, b) => a < b);

            Print(l);
        }
    }
}
