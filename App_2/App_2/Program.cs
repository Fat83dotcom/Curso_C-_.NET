using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte number = 127;
            int n1 = 488888888;
            long n2 = 88888888888;
            int n3 = int.MaxValue;
            float n4 = float.MaxValue;
            Console.WriteLine(number);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}