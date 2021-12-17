using System;

namespace A._Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split('+');
            Array.Sort(str);

            for (int i = 0; i <= str.Length - 1; i++)
            {
                Console.Write(str[i]);

                if (i != str.Length - 1)
                {
                    Console.Write("+");
                }

            }
        }
    }
}