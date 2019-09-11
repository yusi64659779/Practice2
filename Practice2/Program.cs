using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experiance do you have in professional programming:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine("You have " + i + " years of experiences");
        }
    }
}
