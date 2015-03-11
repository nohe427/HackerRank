using System;
using System.Collections.Generic;
using System.IO;


class Solution {
static int lonelyinteger(int[] a) {
    int winningInteger = 0;
    Dictionary<int, int> pairs = new Dictionary<int, int>();
    foreach(int i in a)
        {
        if(pairs.ContainsKey(i))
            {
            pairs[i] = pairs[i] + 1;
        }
        else if(!pairs.ContainsKey(i))
            {
            pairs.Add(i, 1);
        }
    }
    foreach(KeyValuePair<int, int> item in pairs)
    {
        if(item.Value == 1)
        {
            winningInteger = item.Key;
        }
    }
    return winningInteger;
    }
static void Main(String[] args) {
        int res;
        
        int _a_size = Convert.ToInt32(Console.ReadLine());
        int[] _a = new int [_a_size];
        int _a_item;
        String move = Console.ReadLine();
        String[] move_split = move.Split(' ');
        for(int _a_i = 0; _a_i < move_split.Length; _a_i++) {
            _a_item = Convert.ToInt32(move_split[_a_i]);
            _a[_a_i] = _a_item;
        }
        
        res = lonelyinteger(_a);
        Console.WriteLine(res);
        
    }
}
