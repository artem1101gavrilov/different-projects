using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MC m = new MC();
            var d = m.Parameters[0];
            d.T = 5;
            m.Parameters[0] = d;

            foreach (var a in m.Parameters)
            {
                Console.WriteLine(a.T);
            }
            Console.ReadLine();
        }
    }

    public struct MCP
    {
        public float T;
    }

    public class MC
    {
        List<MCP> parameters = new List<MCP>();

        public MC()
        {
            parameters.Add(new MCP(){ T = 1 });
            parameters.Add(new MCP(){ T = 2 });
            parameters.Add(new MCP(){ T = 3 });
        }

        public List<MCP> Parameters
        {
            get { return parameters; }
        }
    }
}
