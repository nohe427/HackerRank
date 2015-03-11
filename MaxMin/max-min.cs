using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int maxMin(int[] listOfInt, int howMany) {
        Array.Sort(listOfInt);
        int finalAnswer = -1;
        for(int i = 0; i < listOfInt.Length - howMany; i++)
        {
          int x = listOfInt[i+howMany-1] - listOfInt[i];
          if(finalAnswer == -1)
          {
            finalAnswer = x;
          }
          if(finalAnswer > x)
          {
            finalAnswer = x;
          }
        }
        return finalAnswer;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        int numberToSelect = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[t];
        for (int i = 0; i < t; i++)
        {
         numbers[i] = (Convert.ToInt32(Console.ReadLine()));
        }

        int unfairnessValue = maxMin(numbers, numberToSelect);
        Console.WriteLine(unfairnessValue);

    }
}
