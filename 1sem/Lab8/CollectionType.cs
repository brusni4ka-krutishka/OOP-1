using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab8
{
    public class CollectionType<Type>:IGeneric<Type> where Type:class
    {
        public List<Type> passwords = new();

        public void Add(Type item)
        {
            passwords.Add(item);
        }

        public Type Delete(int item)
        {
            Type value = passwords[item];
            passwords.RemoveAt(item);
            return value;
        }

        public void Check()
        {
            int count = 0;
            foreach (Type item in passwords)
            {
                count++;
                Console.WriteLine($"Элемент списка под номером {count}\nТип: {item.GetType()}\n");
                
            }
        }
        public void WriteToFile()
        {
            StreamWriter inFile = null;
            try
            {
                inFile = new StreamWriter("..//лаба8.txt", false, Encoding.Default);
                inFile.WriteLine("Этот текст добавлен в файл с помощью класса StreamWriter\nЛюблю записывать строки в файлы");
            }
            finally
            {
                inFile.Close();
            }
        }

        public void ReadFromFile()
        {
            StreamReader fromFile = null;
            try
            {
                fromFile = new StreamReader("..//лаба8.txt");
                int counter = 0;

                foreach (string str in File.ReadAllLines("..//лаба8.txt"))
                {
                    counter++;
                }
                string[] arr = new string[counter];
                for (int i = 0; i < counter; i++)
                {
                    arr[i] = fromFile.ReadLine();
                    Console.Write(arr[i]+"\n");
                }
            }
            finally
            {
                fromFile.Close();
            }
        }
    }
    public class StandartTypes<Type1, Type2, Type3>
    {
        Type1 A { get; set; }
        Type2 B { get; set; }
        Type3 C { get; set; }

        public StandartTypes(Type1 A, Type2 B, Type3 C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public void ShowTypes()
        {
            Console.WriteLine($"Первый тип {A.GetType()} со значением {A}");
            Console.WriteLine($"Второй тип {B.GetType()} со значением {B}");
            Console.WriteLine($"Третий тип {C.GetType()} со значением {C}");
        }
    }
    public class Password // переопределение
    {
        private string parol;
        public string Pass { get; set; }

        public string this[string str]
        {
            set
            {
                parol = value;
            }
            get
            {
                return parol;
            }

        }
    }
}
