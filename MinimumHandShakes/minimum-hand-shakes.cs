using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int minimumShakes(int a) {
        int shakes = 0;
        while(a > 0) {
          a=a-1
          shakes = shakes + (a);
        }
        return shakes;
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
         int val1 = Convert.ToInt32(Console.ReadLine());
         int numberOfShakes = minimumShakes(val1);
         Console.WriteLine(numberOfShakes);
        }

    }
}
