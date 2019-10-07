using System;
using System.Numerics;

class Solution
{
    static void Main()
    {
        ExampleClass e1 = new ExampleClass(1);
        ExampleClass e2 = new ExampleClass(2);
        Console.WriteLine(e1);
        Console.WriteLine(e2);
        e1.Swap(e1, e2);
        Console.WriteLine(e1);
        Console.WriteLine(e2);
        e1.SwapRef(ref e1, ref e2);
        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.ReadLine();
    }
}

class ExampleClass
{
    private int id;
    public ExampleClass(int id)
    {
        this.id = id;
    }
    public override string ToString()
    {
        return "ExampleClass" + id;
    }
    //не работает смена
    public void Swap(ExampleClass ex1, ExampleClass ex2)
    {
        ExampleClass buf = ex1;
        ex1 = ex2;
        ex2 = ex1;
    }
    //работает смена
    public void SwapRef(ref ExampleClass ex1, ref ExampleClass ex2)
    {
        ExampleClass buf = ex1;
        ex1 = ex2;
        ex2 = buf;
    }
}