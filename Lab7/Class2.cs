using System;

namespace Lab7
{
    interface IDo { void Print(); }
    interface IAlive { void Clone(); }

    public abstract class Mechanism : IDo
    {
        protected string name, available;
        protected byte count;
        public string Name { get { return name; } set { name = value; } }
        public string Available { get { return available; } set { available = value; } }
        public byte Count { get { return count; } set
            {
                if (value <= 0)
                    throw new WrongCostValue("Цена не может ровняться нулю!");
                else
                    value = count;
            } 
        }

        public override string ToString()
        {
            Console.WriteLine("Имя техники: " + Name);
            Console.WriteLine("Есть на складе: " + Available);
            Console.WriteLine("Количество: " + Count);
            return "Тип: " + base.ToString();
        }
        public abstract void Clone();
        public abstract void Print();
        //Можно использовать virtual вместо abstract, но не в abstract классе 
    }

    sealed public class Printer : Mechanism, IAlive
    {
        public Printer(string name, string available, byte count)
        {
            this.name = name;
            this.available = available;
            this.count = count;
        }
        public override void Print() => Console.WriteLine("Я печатаю текст!");
        public override void Clone() => Console.WriteLine("Метод абстрактоного класса");
        void IAlive.Clone() => Console.WriteLine("Метод из интерфейса");
    }

    public class Scanner : Mechanism, IAlive
    {
        public Scanner(string name, string available, byte count)
        {
            this.name = name;
            this.available = available;
            this.count = count;
        }

        public override void Print() => Console.WriteLine("Я сканирую и вывожу текст!");
        public override void Clone() => Console.WriteLine("Метод абстрактоного класса");
        void IAlive.Clone() => Console.WriteLine("Метод из интерфейса");
    }

    public class Computer : Mechanism, IAlive
    {
        public Computer(string name, string available, byte count)
        {
            this.name = name;
            this.available = available;
            this.count = count;
        }

        public override void Print() => Console.WriteLine("Я печатаю текст на экране!");
        public override void Clone() => Console.WriteLine("Метод абстрактоного класса");
        void IAlive.Clone() => Console.WriteLine("Метод из интерфейса");
    }

    public class Tablet : Mechanism, IAlive
    {
        public Tablet(string name, string available, byte count)
        {
            this.name = name;
            this.available = available;
            this.count = count;
        }

        public override void Print() => Console.WriteLine("Я печатаю текст на экране без клавиатуры!");
        public override void Clone() => Console.WriteLine("Метод абстрактоного класса");
        void IAlive.Clone() => Console.WriteLine("Метод из интерфейса");
    }

        public class ForObject : Object // переопределение методов Object
        {
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (this.GetType() != obj.GetType()) return false;
                return true;
            }

            public string Name { get; set; }
            readonly int sNumber = 0;

            public override int GetHashCode()
            {
                int hash = string.IsNullOrEmpty(Name) ? 0 : Name.GetHashCode();
                hash = (hash * 47) + sNumber.GetHashCode();
                return hash;
            }

        }

        public static class Printer2
        {
            public static void IAmPrinting(Mechanism mech) => Console.WriteLine(mech.ToString());
        }

    }


