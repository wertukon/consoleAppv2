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
            if (a < 5)
            {
                a = a * a;
            }
            else
            {
                a = a * 10;
            }    
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
