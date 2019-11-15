using System;
using System.Collections.Generic;

namespace _1._6_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string s = Console.ReadLine();

            int cnt = 0;
            string LastLetters = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    cnt++;
                }
            }
            s = s.Replace(".", "")
                 .Replace(",", "")
                 .Replace("-", " ")
                 .Replace("!", "")
                 .Replace("?", "")
                 .Replace(":", "")
                 .Replace(";", "")
                 .Replace("(", "")
                 .Replace(")", "")
                 .Replace("\"", "")
                 .Replace("   "," ")
                 .Replace("  ", " ");

            List<string> sa = new List<string>(s.Split(new char[] { ' ' }));
            for (int i = 0; i < sa.Count; i++)
            {
                if(sa[i].Length == 1)
                {
                    sa.RemoveAt(i);
                }
                LastLetters += sa[i][sa[i].Length - 1];
            }

            Console.WriteLine($"Количество слов: {sa.Count};");
            Console.WriteLine($"Количество символов без пробелов: {cnt};");
            Console.WriteLine($"Соотношение количество символов без пробелов к количеству слов: {(double)cnt / sa.Count};");
            Console.WriteLine($"Слово из последних символов слов: {LastLetters};");
        }
    }
}
