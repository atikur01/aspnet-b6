using System;

namespace A._Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if ( i==0 && Char.IsUpper(str[i]) == false)
                {
                    Console.Write(Char.ToUpper(str[i]));
                    continue;
                }
                Console.Write(str[i]);
            }
           
                
            
        }
    }
}
