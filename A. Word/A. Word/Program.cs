using System;

namespace A._Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0, u = 0, i;
            var z = Console.ReadLine();
            char[] s = new char[z.Length];
            s = z.ToCharArray();

            for (i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    u++;
                else if (s[i] >= 97 && s[i] <= 122)
                {
                    l++;
                }
            }
            if (u > l)
            {
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] >= 97 && s[i] <= 122)
                    {
                        s[i] = (char)(65 + s[i] - 97);
                    }
                }
            }
            else
            {
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] >= 65 && s[i] <= 90)
                    {
                        s[i] = (char)(97 + s[i] - 65);
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
