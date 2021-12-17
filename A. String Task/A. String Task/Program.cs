using System;

namespace A._String_Task
{
    class Program
    {
        public static bool CheckVowel(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y')
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower();

            for (int i = 0; i < str.Length; i++)
            {

                if (CheckVowel(str[i]))
                {
                    continue;
                }
                if (CheckVowel(str[i]) == false)
                {
                    Console.Write(".");
                    Console.Write(str[i]);
                }
            }
        }
    }
}
