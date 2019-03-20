using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpTasks
{
    struct Vector3
    {
        public int x { get; protected set; }
        public int y { get; private set; }
        public int z { get; private set; }
        public Vector3(int x1, int y1, int z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
    }

    class Transform
    {
        public Vector3 position;
    }

    class GameObject
    {
        public Transform transform = new Transform();
        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameObject a = new GameObject();
            //a.transform.position.x = 2; //ERROR
            Console.Write(a.transform.position.x);

            var s = new Vector3();
            //s.x += 1; //ERROR

            Console.ReadKey(); 
        }
    }
}
