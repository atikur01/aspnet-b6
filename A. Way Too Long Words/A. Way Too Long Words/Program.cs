using System;

namespace A._Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();

                if (str.Length > 10)
                {
                    Console.WriteLine($"{str[0]}{str.Length - 2}{str[str.Length - 1]}");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
