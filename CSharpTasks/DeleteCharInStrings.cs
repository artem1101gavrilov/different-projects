using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Solution
{

    static void Main()
    {
        string obs = "!@#$%^&*()";
        string lalala = "sd(f)sf#$%g*d";

        foreach (char c in obs)
        {
            lalala = lalala.Replace(c.ToString() , string.Empty);
        }

        lalala = new string((from c in lalala
                          where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                          select c).ToArray());
        
        Console.WriteLine(lalala);
        Console.ReadLine();
    }

}
