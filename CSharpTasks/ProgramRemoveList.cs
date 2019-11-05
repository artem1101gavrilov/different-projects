using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        List<int> a = new List<int>() {1, 0, 2, 0, 3, 0, 4, 0, 0 };
        for (int i = 0; i < a.Count; ++i)
        {
            if (a[i] == 0) a.Remove(a[i]);
        }
        for (int i = 0; i < a.Count; ++i)
        {
            Console.Write(a[i]); // 1 2 3 4 0
        }

        List<int> b = new List<int>() { 1, 0, 2, 0, 3, 0, 4, 0, 0 };
        for (int i = 0; i < b.Count; ++i)
        {
            if (b[i] == 0)
            {
                b.Remove(b[i]);
                --i;
            }
        }
        for (int i = 0; i < b.Count; ++i)
        {
            Console.Write(b[i]); // 1 2 3 4
        }
        
        Console.ReadLine();
    }
}
