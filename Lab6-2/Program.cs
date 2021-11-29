using System;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string S = Console.ReadLine();
            S = S.Replace(" ", string.Empty);

            char[] ar = S.ToCharArray();
            Array.Reverse(ar);
            string revS = new String(ar);

            if (S == revS)
            {
                Console.WriteLine("Данное предложение является перевртышем");
            }
            else
            {
                Console.WriteLine("Данное предложение не является перевртышем");
            }

            Console.ReadKey();
        }
    }
}

