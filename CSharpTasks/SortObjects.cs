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

class Solution
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Key { get; set; }
        public int Auro { get; set; }
        public Person(string name, int key, int auro)
        {
            Name = name;
            Key = key;
            Auro = auro;
        }

        public int CompareTo(object obj)
        {
            int c = ((Person)obj).Key.CompareTo(this.Key);
            if (c == 0) return ((Person)obj).Auro.CompareTo(this.Auro);
            return c;
        }
    }

    static void Main(string[] args)
    {
        var listPerson = new List<Person>();
        listPerson.Add(new Person("1", 100, 200));
        listPerson.Add(new Person("2", 300, 100));
        listPerson.Add(new Person("3", 300, 500));
        listPerson.Add(new Person("4", 200, 170));
        listPerson.Add(new Person("5", 200, 190));

        listPerson.Sort();

        foreach (var p in listPerson)
        {
            Console.WriteLine(p.Name);
        }

        //Получил ответ
        //3
        //2
        //5
        //4
        //1

        Console.ReadKey();
    }

}