using System;
 
namespace A._Football
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            if (str.Contains("0000000") || str.Contains("1111111"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}