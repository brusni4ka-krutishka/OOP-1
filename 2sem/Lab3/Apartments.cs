using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace Lab2
{
    public class Apartments : IPrototype<Apartments>
    {
        public Flat Flat {get;set;}
        public Adress Address { get; set; }
        public Apartments(Flat flat, Adress address)
        {
            Flat = flat;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Flat.Floor} {Address.Flatt}";
        }
        public Apartments Clone()
        {
            return (Apartments)this.MemberwiseClone();
        }

        public Apartments DeepCopy()
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return (Apartments)formatter.Deserialize(stream);
            }
        }
    }
    //-------------------------------------------------Adapter (преобразование интерфейса одного класса в другое)
    class Adapter
    {
        static void Main(string[] args)
        {
            // путешественник
            Driver driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel();
            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

        }
    }
    interface ITransport
    {
        void Drive();
    }
    // класс машины
    class Auto : ITransport
    {
        public void Drive()
        {
            MessageBox.Show("Машина едет по дороге");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    // интерфейс животного
    interface IAnimal
    {
        void Move();
    }
    // класс верблюда
    class Camel : IAnimal
    {
        public void Move()
        {
            MessageBox.Show("Верблюд идет по пескам пустыни");
        }
    }
    // Адаптер от Camel к ITransport
    class CamelToTransportAdapter : ITransport
    {
        Camel camel;
        public CamelToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
    //-----------------------------------------------Стратегия
    //представляет шаблон проектирования, который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость
    class Vehicle
    {
        static void Main(string[] args)
        {
            Car auto = new Car(4, "Volvo", new PetrolMove());
            auto.Move();
            auto.Movable = new ElectricMove();
            auto.Move();
        }
    }
    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            MessageBox.Show("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            MessageBox.Show("Перемещение на электричестве");
        }
    }
    class Car
    {
        protected int passengers; // кол-во пассажиров
        protected string model; // модель автомобиля

        public Car(int num, string model, IMovable mov)
        {
            this.passengers = num;
            this.model = model;
            Movable = mov;
        }
        public IMovable Movable { private get; set; }
        public void Move()
        {
            Movable.Move();
        }
    }

}
