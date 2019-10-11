using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        int[] arr = { 3,2,1,2,1,4,5,8,6,7,4,2 };
        List<int> l = new List<int>(arr);
        int max = 0;
        for (int i = 0; i < l.Count; ++i)
            if (max < l.LastIndexOf(l[i]) - l.IndexOf(l[i])) max = l.LastIndexOf(l[i]) - l.IndexOf(l[i]);
        Console.WriteLine(max);
        Console.ReadLine();
    }
}
