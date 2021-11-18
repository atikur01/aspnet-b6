using System;
using System.Collections.Generic;

namespace A._Boy_or_Girl
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            
            var myhash1 = new HashSet<char>();

            foreach (var ch in s)
            {
                myhash1.Add(ch);
            }

            if (myhash1.Count % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
            
           
            
        }
    }
}