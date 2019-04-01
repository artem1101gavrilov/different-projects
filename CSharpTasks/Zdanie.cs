using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpTasks
{
    class Zdanie
    {
        int _GDol;
        public virtual int GDol
        {
            get { return _GDol; }
            set { _GDol = value; }
        }
        int _Beer;
        public virtual int Beer
        {
            get { return _Beer; }
            set { _Beer = value; }
        }
        string _ekonomika;
        public virtual string EkonomikaText
        {
            get
            {
                _ekonomika = "";
                if (_GDol != 0)
                    _ekonomika += "$$ = " + _GDol.ToString() + "\n";
                if (_Beer != 0)
                    _ekonomika += "Beer = " + _Beer.ToString() + "\n";
                return _ekonomika;
            }
        }
    }

    class Pivovarnya : Zdanie
    {

    }

    class Bar : Zdanie
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            bar.GDol = 5;
            bar.Beer = 9;
            Console.Write(bar.EkonomikaText);
            Console.ReadKey(); 
        }
    }
}
