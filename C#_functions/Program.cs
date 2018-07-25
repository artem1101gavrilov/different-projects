using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;



namespace CsharpDictionarySort
{
    class Program
    {
        public static void ShowIterator<K, V>(Dictionary<K, V> myList)
        {
            if (myList == null)
                return;

            string s = "";

            foreach (KeyValuePair<K, V> kvp in myList)
            {
                s += string.Format("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value) + Environment.NewLine;
                //Console.Write(kvp.Value);
            }

            Console.Write(s);
        }  

        public static void Form1()  
        {   
            Dictionary<int, string> myList =   
                new Dictionary<int, string>();  
      
            myList.Add(2, "Sasha");  
            myList.Add(7, "Petia");  
            myList.Add(6, "Ania");  
            myList.Add(8, "Dasha");  
            myList.Add(4, "Veronica");  
  
            ShowIterator<int, string>(myList);  
        }  

        static void Main(string[] args)
        {
            Form1();
            Console.ReadKey(); 
        }
    }
}
