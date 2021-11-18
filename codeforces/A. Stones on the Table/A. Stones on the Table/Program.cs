using System;

namespace A._Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();

            int count = 0;

            for (int i = 0; i <= s.Length-2; i++)
            {
                if( s[i] == s[i+1]  )
                {
                    count++;
                }
                
            }

            Console.WriteLine(count);

        }
    }
}