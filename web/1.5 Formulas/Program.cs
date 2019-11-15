using System;

namespace _1._5_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x;
            while (true)
            {
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Console.WriteLine(
                Math.Atan(x + Math.Sqrt(1 + x*x))
                );
            Console.WriteLine(
                (1 / (4 * Math.Sqrt(3))) * Math.Log((Math.Sqrt(x*x + 2) - (x * Math.Sqrt(3))/((Math.Sqrt(x * x + 2) + (x * Math.Sqrt(3))))))
                );
            Console.WriteLine(
                (1 / 2 * Math.Sqrt(2) * Math.Atan(x * Math.Sqrt(2) / Math.Sqrt(1 + x * x * x * x)))
                );
        }
    }
}
