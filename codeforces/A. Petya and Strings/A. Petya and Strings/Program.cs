using System;

namespace A._Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().ToUpper();
          
            var str2 = Console.ReadLine().ToUpper();


            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine(0);
            }
            if(string.Compare(str1, str2) == -1)
            {
                Console.WriteLine(-1);
            }
            if (string.Compare(str1, str2) == 1)
            {
                Console.WriteLine(1);
            }

        }
    }
}
