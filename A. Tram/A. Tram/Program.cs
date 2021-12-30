using System;

namespace A._Tram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ans, i, k, maxx = 0;

            int[] a = new int[1000];
            int[] b = new int[1000];


            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                var g = Console.ReadLine();
                var h = g.Split(' ');
                a[i] = int.Parse(h[0]);
                b[i] = int.Parse(h[1]);

            }
            k = a[0];
            for (i = 0; i < n; i++)
            {
                ans = b[i] - a[i] + k;
                k = ans;
                if (ans > maxx)
                    maxx = ans;
            }

            Console.WriteLine(maxx);
        }
    }
}
