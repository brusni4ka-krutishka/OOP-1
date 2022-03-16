using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
/*---------------------------------------------------------------------------------------*/
    class Set
    {
        private readonly HashSet<string> hs1;
        private readonly string hs2;

        public Set(HashSet<string> hs1)
        {
            this.hs1 = hs1;
        }
        public Set(HashSet<string> hs1, string hs2)
        {
            this.hs1 = hs1;
            this.hs2 = hs2;
        }
/*---------------------------------------------------------------------------------------*/
        public override int GetHashCode()
        {
            return 0;
        }
        public override bool Equals(object o)
        {
            return true;
        }
/*---------------------------------------------------------------------------------------*/
        public static HashSet<string> operator >> (Set set1, int unused)
        {
            string[] mass = new string[set1.hs1.Count-1];
            HashSet<string> tempSet = new HashSet<string>();
            set1.hs1.CopyTo(mass, 0, set1.hs1.Count - 1);
            set1.hs1.Clear();
            foreach (var item in mass)
            {
                tempSet.Add(item);
            }
            return tempSet;
        }
        public static HashSet<string> operator <<(Set set1, int unused)
        {
            HashSet<string> tempSet = new HashSet<string>();
            foreach (var item in set1.hs1)
            {
                tempSet.Add(item);
            }
            tempSet.Add(set1.hs2);

            return tempSet;
        }

        public static bool operator > (Set set1, Set set2)
        {
            byte counter=0; bool flag;
            foreach (var item in set1.hs1)
            {
                if (set2.hs1.Contains(item)==false)
                {
                    counter++;
                    break;
                }
            }
            flag = counter == 0;
            return flag;
        }

        public static bool operator <(Set set1, Set set2)
        {
            byte counter = 0; bool flag;
            foreach (var item in set2.hs1)
            {
                if (set1.hs1.Contains(item) == false)
                {
                    counter++;
                    break;
                }
            }
            flag = counter == 0;
            return flag;
        }
        public static bool operator != (Set set1, Set set2)
        {
            byte counter = 0; bool flag;
            foreach (var item in set2.hs1)
            {
                if ( (set1.hs1.Count== set2.hs1.Count) && (set1.hs1.Contains(item)))
                {
                    counter++;
                    break;
                }
            }
            flag = counter == 0;
            return flag;
        }
        public static bool operator == (Set set1, Set set2)
        {
            byte counter = 0; bool flag;
            foreach (var item in set2.hs1)
            {
                if (set1.hs1.Contains(item) == false)
                {
                    counter++;
                    break;
                }
            }
            flag = counter == 0;
            return flag;
        }

        public static HashSet<string> operator %(Set set1, Set set2)
        {
            HashSet<string> tempSet = new HashSet<string>();
            foreach (var item in set1.hs1)
            {
                if ((set2.hs1.Contains(item)))
                    tempSet.Add(item);
            }
            return tempSet;
        }
/*---------------------------------------------------------------------------------------*/
        public static void Shortest(Set set1)
        {
            string[] mass = new string[set1.hs1.Count];
            set1.hs1.CopyTo(mass);
            Array.Sort(mass);
            Console.Write(mass[0]);
        }

        public static void Ordering(Set set1)
        {
            string[] mass = new string[set1.hs1.Count];
            set1.hs1.CopyTo(mass);
            Array.Sort(mass);
            foreach (var item in mass)
            {
                Console.Write(item+ " ");
            }
        }

    }
    /*---------------------------------------------------------------------------------------*/



    class Program
    {
        static void Main()
        {
            HashSet<string> Hs1 = new HashSet<string>() { "2", "1", "3", "4" },
                Hs2 = new HashSet<string>() { "2", "5","3" },
                Hs3 = new HashSet<string>() { },
                Hs4 = new HashSet<string>() { "ABCD", "ABC", "AB" },
                Hs5 = new HashSet<string>() { "2", "1", "3", "4" };

            Set set1 = new Set(Hs1),
                set2 = new Set(Hs2),
                set3 = new Set(Hs3),
                set4 = new Set(Hs2, "Z"),
                set5 = new Set(Hs5),
                set6 = new Set(Hs4);
            Console.WriteLine("Исходное множество: ");
            foreach (var item in Hs1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Удаление элемента из множества: ");
            Hs3 = set1 >> 1;
            foreach (var item in Hs3)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Проверка на подмножество:");
            foreach (var item in Hs2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(set2 > set3);
            foreach (var item in Hs3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Проверка на неравенство:");
            foreach (var item in Hs2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(set2 != set3);
            foreach (var item in Hs3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Добавление элемента в множество: ");
            Hs3 = set4 << 1;
            foreach (var item in Hs3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Пересечение:");
            Hs3 = set2 % set5;
            foreach (var item in Hs3)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Cамое короткое слово в ");
            foreach (var item in Hs4)
            {
                Console.Write(item + " ");
            }
            Console.Write($" это "); Set.Shortest(set6);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Упорядочивание в ");
            foreach (var item in Hs5)
            {
                Console.Write(item + " ");
            }
            Console.Write($" это "); Set.Ordering(set5);
            Console.WriteLine();

            Console.WriteLine();
            Owner owner = new Owner(1780401, "Eugene", "BSTU");
            owner.GetInfo();

            Console.ReadKey();

            
        }
    }







}
