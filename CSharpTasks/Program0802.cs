using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpTasks
{
    class Program
    {
        public static void Kod8(ref string a)
        {
            Console.WriteLine(a);
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                b += (char)((int)a[i] + i*2 + 100);
            }
            a = b;
        }

        public static void RazKod8(ref string a)
        {
            Console.WriteLine(a);
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                b += (char)((int)a[i] - i * 2 - 100);
            }
            a = b;
        }

        public static void Task8()
        {
            string a = "qwerty";
            Kod8(ref a);
            RazKod8(ref a);
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            //qwerty
            //OYIUac
            //qwerty
            Task8();
            Console.ReadKey(); 
        }
    }
}
