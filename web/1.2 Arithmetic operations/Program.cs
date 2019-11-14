using System;

namespace _1._2_Arithmetic_operations
{
    class Program
    {
        enum Operations        
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        static void Operation(Operations op)
        {
            Console.WriteLine("Введите операнды:");
            double op1, op2;
            try
            {
                Console.Write("1. ");
                op1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("2. ");
                op2 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не корректный операнд");
                Console.WriteLine("Введите оператор * / + - или q для выхода:");
                return;
            }
           

            Console.Write("Результат: ");
            switch (op)
            {
                case Operations.Add:
                    Console.WriteLine((op1 + op2).ToString());
                    break;
                case Operations.Subtract:
                    Console.WriteLine((op1 - op2).ToString());
                    break;
                case Operations.Multiply:
                    Console.WriteLine((op1 * op2).ToString());
                    break;
                case Operations.Divide:
                    Console.WriteLine((op1 / op2).ToString());
                    break;

            }
            Console.WriteLine("Введите оператор * / + - или q для выхода:");
            // Console.WriteLine("Complete!");
        }

        static void Main(string[] args)
        {
            bool flag = true;
            string op;
            Console.WriteLine("Введите оператор * / + - или q для выхода:");
            while (flag)
            {
                
                op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        Operation(Operations.Add);
                        break;
                    case "-":
                        Operation(Operations.Subtract);
                        break;
                    case "*":
                        Operation(Operations.Multiply);
                        break;
                    case "/":
                        Operation(Operations.Divide);
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный оператор, повторите ввод:");
                        break;
                }
            }
        }
    }
}
