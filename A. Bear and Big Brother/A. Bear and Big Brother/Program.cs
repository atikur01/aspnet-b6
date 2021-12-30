using System;

namespace A._Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            var str = Console.ReadLine().Split(' ');
            a = int.Parse(str[0]);
            b = int.Parse(str[1]);

            int x;
            for (int year = 1; ; year++)
            {
                a = a * 3;
                b = b * 2;

                if( a > b)
                {
                    x = year;
                    break;
                }
            }

            Console.WriteLine(x);

            
        }
    }
}
