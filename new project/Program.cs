using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x);

            a < 5 ? a = a * a : a = a * 10;

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
