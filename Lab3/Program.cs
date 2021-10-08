using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    partial class Abiturient //класс partial
    {
        private readonly byte id = 0; //Поле только для чтения
        private byte[] marks = new byte[4] {1,1,1,1};
        private const byte fukoff = 1; //поле-константа

        //Конструктор с параметрами
        public Abiturient(string name, string lastname, string patronymic, string adress, string telephone, byte[] marks)
        {
            this.marks = marks;
            counterObj++;
        }
        public Abiturient() { } //Без параметров

        //По умолчанию создан сам

        /*
         * закрытый конструктор
          private Abiturient() { Console.WriteLine("Закрытый конструктор");}
        */

        static Abiturient() { }  //Статический конструктор

        public byte Id //Аксессоры
        {
            get
            {
                if (id > 0) return id;
                else return 0;
            }
        }
        public string Name { get; set; } //Автоматические свойства
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public byte[] Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public byte Refnout(ref byte x, out byte y) //ref и out параметры
        {
            y = ++x;
            return y;
        }

        static byte counterObj = 0; //статическое поле

        public static void objCounter() { Console.WriteLine(counterObj); } //статический метод


        public byte Average_score()  //"Пользовательский" метод
        {
            int score = 0;
            for (byte i = 0; i < marks.Length; i++)
            {
                score+= marks[i];
            }
            return  (byte)(score / marks.Length);
        }
        public void Min()   //"Пользовательский" метод
        {
            Array.Sort(marks);
        }
        public void Max()   //"Пользовательский" метод
        {
            Array.Sort(marks);
        }

        public Abiturient(byte[] marks) {
            this.marks = marks;
    }


        class Program
        {
            static void Main(string[] args)
            {

                Console.Write("Введите кол-во абитуриентов: ");
                byte counter = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                Abiturient[] database = new Abiturient[counter];

                for (byte i = 0; i < counter; i++)
                {
                    database[i] = new Abiturient();
                    Console.Write("Введите имя студента {0}: ", i + 1);
                    database[i].Name = Console.ReadLine();

                    Console.Write("Введите фамилию студента {0}: ", i + 1);
                    database[i].Lastname = Console.ReadLine();

                    Console.Write("Введите отчество студента {0}: ", i + 1);
                    database[i].Patronymic = Console.ReadLine();

                    Console.Write("Введите адрес студента {0}: ", i + 1);
                    database[i].Adress = Console.ReadLine();

                    Console.Write("Введите телефон студента {0}: ", i + 1);
                    database[i].Telephone = Console.ReadLine();

                    Console.WriteLine("Введите балл студента {0} по...", i + 1);

                    Console.Write("Физике: ");
                    database[i].Marks[0] = byte.Parse(Console.ReadLine());
                    Console.Write("Математике: ");
                    database[i].Marks[1] = byte.Parse(Console.ReadLine());
                    Console.Write("Английскому: ");
                    database[i].Marks[2] = byte.Parse(Console.ReadLine());
                    Console.Write("Русскому: ");
                    database[i].Marks[3] = byte.Parse(Console.ReadLine());


                }
                Console.WriteLine();
                Console.WriteLine("Список абитуриентов с неудовлетворительными оценками: ");
                for (byte i = 0; i < database.Length; i++)
                {
                    if (database[i].Average_score() < 6)
                    {
                        Console.WriteLine($"Студент {database[i].Name + database[i].Lastname}. Средний балл: {database[i].Average_score()}");
                    }

                }
                Console.WriteLine();
                Console.Write("Список абитуриентов с баллом выше заданного:\nВведите балл: "); byte score = byte.Parse(Console.ReadLine());
                for (byte i = 0; i < database.Length; i++)
                {
                    if (database[i].Average_score() > score)
                    {
                        Console.WriteLine($"Студент {database[i].Name + database[i].Lastname}. Средний балл: {database[i].Average_score()}");
                    }

                }

                Console.WriteLine();

                byte[] mass = { 1, 5, 5, 6 };
                Abiturient a1 = new Abiturient(mass);
                Abiturient a2 = new Abiturient(mass);
                Console.WriteLine("Хэш " + a1.GetHashCode());
                Console.WriteLine("Тип " + a2.GetType());
                Console.WriteLine("К строке " + a1.ToString());
                Console.WriteLine("Эквивалентны? " + a1.Equals(a2));

                var user = new { Name = "Eugene", Age = 18 }; //Анонимный тип
                Console.WriteLine(user.Name);

                Console.ReadKey();

            }
        }
    }
}
