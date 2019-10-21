using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;

class Solution
{
    static void Main() 
    {
        string h = "???R??E";
        Console.WriteLine(A(h, 0, 1, 0));
        Console.ReadLine();
    }

    static int A(string str, int l, int k, int currentK)
    {
        int count = 0;
        if (l == str.Length) return 1;
        if (str[l] == '?')
        {
            if (currentK < k) count += A(str, l + 1, k, currentK + 1);
            count += A(str, l + 1, k, 0);
        }
        else if (str[l] == 'R')
        {
            count += A(str, l + 1, k, 0);
        }
        else if (str[l] == 'E')
        {
            if (currentK == k) return 0;
            count += A(str, l + 1, k, currentK + 1);
        }
        return count;
    }
}