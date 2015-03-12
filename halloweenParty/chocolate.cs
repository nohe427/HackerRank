using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halloweenPart
{
    class Solution
    {

        public static bool IsOdd(Int64 value)
        {
            return value % 2 != 0;
        }

        static string infiniteChocolate(Int64 slices)
        {
            int finalAnswer = 0;
            string answerString = "";
            if (IsOdd(slices))
            {
                answerString = (((Convert.ToDouble(slices) / 2) + .5) * ((Convert.ToDouble(slices) / 2) - .5)).ToString();
            }
            else
            {
                answerString = ((slices / 2) * (slices / 2)).ToString();
            }
            return answerString;
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                Int64 numberToCalculate = Convert.ToInt64(Console.ReadLine());
                string answer = infiniteChocolate(numberToCalculate);
                Console.WriteLine(answer);
            }

        }
    }

}
