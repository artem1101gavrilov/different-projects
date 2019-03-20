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
        public int x;
        public int y;
        public int z;
        public Vector3(int x1, int y1, int z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
    }

    class Transform
    {
        Vector3 vector3;
        public Vector3 position 
        {
            get{
                return vector3;
            }
            set
            {
                vector3 = value;
            }
        }
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
            a.transform.position = new Vector3(1, 2, 3);
            Console.Write(a.transform.position.x);

            var s = new Vector3();
            s.x += 1;

            Console.ReadKey(); 
        }
    }
}
