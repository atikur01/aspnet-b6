using System;

namespace A._Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int x = 0;

            while(n>0){

                var str = Console.ReadLine();

                foreach (var item in str)
                {
                    if(item == '+')
                    {
                        x += 1;
                        break;
                    }

                    if(item == '-')
                    {
                        x -= 1;
                        break;
                    }
                }

                n--;
            }

            Console.WriteLine(x);
        }
    }
}
