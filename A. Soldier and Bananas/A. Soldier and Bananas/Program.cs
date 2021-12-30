using System;

namespace A._Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, w , totalCost = 0;

            var str = Console.ReadLine().Split(' ');
            k = int.Parse(str[0]); //the cost of the first banana
            n = int.Parse(str[1]); //initial number of dollars the soldier has
            w = int.Parse(str[2]); //number of bananas he wants

            for (int i = 1; i <= w; i++)
            {
                totalCost += i * k;
            }

            if (totalCost <= n)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(totalCost - n);
            }

        }
    }
}
