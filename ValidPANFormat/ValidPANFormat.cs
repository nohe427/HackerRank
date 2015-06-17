//https://www.hackerrank.com/challenges/valid-pan-format
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Regex regex = new Regex(@"[A-Z]{5}\d{4}[A-Z]{1}");
            int iterations = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < iterations; i++)
            {
                string value = Console.ReadLine();
                bool z = regex.IsMatch(value);
                Console.WriteLine(z ? "YES":"NO");
            }
        }
    }
}
