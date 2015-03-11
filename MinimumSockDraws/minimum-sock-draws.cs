using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int minimumDraws(int a) {
        return a+1;
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
         int val1 = Convert.ToInt32(Console.ReadLine());
         int numberOfDraws = minimumDraws(val1);
         Console.WriteLine(numberOfDraws);
        }

    }
}    
