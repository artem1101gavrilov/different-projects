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
        public static void Task7()
        {
            List<Records> NameList = new List<Records>();
            NameList.Add(new Records(){Name = "123", score = 13});

            //Запись
            FileStream fs = new FileStream("save.qwe", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            NameClassSave nameClassSave = new NameClassSave(NameList);
            bFormatter.Serialize(fs, nameClassSave);
            fs.Close();

            //Считывание
            FileStream fs2 = new FileStream("save.qwe", FileMode.Open);
            BinaryFormatter bFormatter2 = new BinaryFormatter();
            try
            {
                NameClassSave nameClassSave2 = (NameClassSave)bFormatter2.Deserialize(fs2);
                Console.WriteLine(nameClassSave2.NameList[0].Name);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs2.Close();
            }
        }

        static void Main(string[] args)
        {
            Task7();
            Console.ReadKey(); 
        }
    }

    [Serializable]
    public struct Records
    {
        public string Name;
        public int score;
    }

    [Serializable]
    public class NameClassSave
    {
        public List<Records> NameList;
        public NameClassSave(List<Records> NewNameList)
        {
            NameList = NewNameList;
        }
    }
}
