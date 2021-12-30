using System;

namespace A._HQ9_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var ssp = s.Split(' ');
            char[] ch = s.ToCharArray();
            char c;
            int flag = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (ch[i] == 'H' || ch[i] == 'Q' || ch[i] == '9')
                {
                    flag = 1;
                    break;
                }


            }

            if (flag == 1)
            {
                Console.WriteLine("YES");
            }
            else if (flag == 0)
            {
                Console.WriteLine("NO");
            }
        }
    }
}
