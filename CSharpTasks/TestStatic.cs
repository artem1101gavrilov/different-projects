using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        ExampleClass Example = new ExampleClass();
        Console.Write(Example.e);
        Console.ReadLine();
    }
}

class ExampleClass
{
    static int i;
    public int e;
    public ExampleClass()
    {
        e = i;
    }
    static ExampleClass()
    {
        i = 1101;
    }
}