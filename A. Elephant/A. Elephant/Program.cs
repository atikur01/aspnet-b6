using System;

namespace A._Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 5 == 0) Console.WriteLine(n / 5);
            else Console.WriteLine((n / 5) + 1);
        }
    }
}
