using System;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string startString = Console.ReadLine();
            string[] words = startString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int max = words[0].Length, min = words[0].Length;
            foreach (string str in words)
            {
                if (str.Length > max) max = str.Length;
            }
            Console.WriteLine("Длина самого длинного слова: " + max);
            Console.ReadLine();
        }
    }
}
