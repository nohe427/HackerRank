//https://www.hackerrank.com/challenges/staircase Staircase Challenge
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 t = Convert.ToInt32(Console.ReadLine());
            Int64 i = 0;
            string output = "";
            while (i < t)
            {
                output += "#";
                Console.WriteLine(output.PadLeft(t, ' '));
                i++;
            }
        }
    }
}
