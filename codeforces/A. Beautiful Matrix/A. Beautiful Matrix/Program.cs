using System;
using System.Collections.Generic;

namespace A._Beautiful_Matrix
{
    class Program
    {
        public static List<int> InputRow()
        {
            List<int> arr = new List<int>();
            var str = Console.ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                arr.Add(int.Parse(str[i]));
            }

            return arr;
        }
        static void Main(string[] args)
        {
            var arr = new int[5,5];

            int x = 0, y = 0;

            for (int i = 0; i < 5; i++)
            {
                var row = InputRow();

                for (int j = 0; j < 5; j++)
                {
                    arr[i,j] = row[j];

                    if (row[j] == 1)
                    {
                        x = i+1;
                        y = j+1;
                    }
                }
            }

            Console.WriteLine( Math.Abs(x-3) + Math.Abs(y-3) );
           
        }
    }
}
