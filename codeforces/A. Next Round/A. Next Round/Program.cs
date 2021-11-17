using System;

namespace A._Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ');
            var n = int.Parse(str[0]);
            var k = int.Parse(str[1]);
            var count = 0;

            var input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                if(int.Parse(input[i]) >= int.Parse(input[k-1]) && int.Parse(input[i]) > 0)
                {
                    count++;
                }
            }


            Console.WriteLine(count);
        }
    }
}
