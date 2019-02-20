using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpTasks
{
    class GameObject
    {
        public string name;
        public float x;
    }

    class Program
    {

        public static void ExampleList()
        {
            List<GameObject> listGO = new List<GameObject>();
            listGO.Add(new GameObject());
            listGO[0].name = "GO1";
            Console.WriteLine(listGO[0].name);
        }

        static void Main(string[] args)
        {
            ExampleList();
            Console.ReadKey(); 
        }
    }
}
