using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpTasks
{
    struct Vector2
    {
        public int x;
        public int y;
        public Vector2(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
    }

    class Transform
    {
        public Vector2 position;
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
            var a = new GameObject();
            a.transform.position.x = 2;
            Console.Write(a.transform.position.x);
            Console.ReadKey(); 
        }
    }
}
