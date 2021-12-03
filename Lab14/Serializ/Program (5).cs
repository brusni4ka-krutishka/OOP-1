using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Laba14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<--------------> Задание 1 <-------------->\n");
            Car car1 = new Car("Nissan GT-R", 1, 320);
            Car car2 = new Car("Range Rover", 2, 250);
            Car car3 = new Car("Infiniti G35X", 3, 250);
            Console.WriteLine("Бинарная сериализация\n");
            Serialize.Binary(car1);
            Serialize.Binary(car2);
            Serialize.Binary(car3);

            Console.WriteLine("\nБинарная десериализация\n");
            Car car1_Deserialize = Serialize.BinaryDeserialize(car1);
            Car car2_Deserialize = Serialize.BinaryDeserialize(car2);
            Car car3_Deserialize = Serialize.BinaryDeserialize(car3);

            Console.WriteLine("\nПосле бинарной десериализации\n");
            ShowInfo(car1_Deserialize);
            ShowInfo(car2_Deserialize);
            ShowInfo(car3_Deserialize);

            Console.WriteLine("Cериализация SOAP\n");
            Serialize.SOAP(car1);
            Serialize.SOAP(car2);
            Serialize.SOAP(car3);

            Console.WriteLine("\nSOAP десериализация\n");
            car1_Deserialize = Serialize.SOAPDeserialize(car1);
            car2_Deserialize = Serialize.SOAPDeserialize(car2);
            car3_Deserialize = Serialize.SOAPDeserialize(car3);

            Console.WriteLine("\nПосле SOAP десериализации\n");
            ShowInfo(car1_Deserialize);
            ShowInfo(car2_Deserialize);
            ShowInfo(car3_Deserialize);

            Console.WriteLine("Cериализация JSON\n");
            Serialize.JSON(car1);
            Serialize.JSON(car2);
            Serialize.JSON(car3);

            Console.WriteLine("\nJSON десериализация\n");
            car1_Deserialize = Serialize.JSONDeserialize(car1);
            car2_Deserialize = Serialize.JSONDeserialize(car2);
            car3_Deserialize = Serialize.JSONDeserialize(car3);

            Console.WriteLine("\nПосле JSON десериализации\n");
            ShowInfo(car1_Deserialize);
            ShowInfo(car2_Deserialize);
            ShowInfo(car3_Deserialize);

            Console.WriteLine("Cериализация XML\n");
            Serialize.XML(car1);
            Serialize.XML(car2);
            Serialize.XML(car3);

            Console.WriteLine("\nXML десериализация\n");
            car1_Deserialize = Serialize.XMLDeserialize(car1);
            car2_Deserialize = Serialize.XMLDeserialize(car2);
            car3_Deserialize = Serialize.XMLDeserialize(car3);

            Console.WriteLine("\nПосле XML десериализации\n");
            ShowInfo(car1_Deserialize);
            ShowInfo(car2_Deserialize);
            ShowInfo(car3_Deserialize);

            Console.WriteLine("\n<--------------> Задание 2 <-------------->\n");
            List<Car> cars = new List<Car>() { car1, car2, car3 };
            Serialize.XMLCollection(cars);
            cars.Clear();
            cars = Serialize.XMLDeserializeCollection(cars);
            Console.WriteLine("Коллекция после десериализации\n");
            foreach(Car c in cars)
            {
                ShowInfo(c);
            }
            Console.WriteLine("\n<--------------> Задание 3 <-------------->\n");
            Console.WriteLine("Вывод всех моделей\n");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("XMLCarCollection.xml");
            XmlElement xmlElement = xmlDocument.DocumentElement;
            XmlNodeList xmlNodeList = xmlElement.SelectNodes("Car");
            foreach(XmlNode n in xmlNodeList)
            {
                Console.Write(n.FirstChild.FirstChild.Value + " | ");
            }
            Console.WriteLine("\n\nМодель - скорость\n");

            xmlNodeList = xmlElement.SelectNodes("Car");
            foreach (XmlNode n in xmlNodeList)
            {
                Console.WriteLine(n.FirstChild.FirstChild.Value + " <> " + n.LastChild.FirstChild.Value);
            }

            Console.WriteLine("\n<--------------> Задание 4 <-------------->\n");

            XmlLinq.CountriesCreate();
            XmlLinq.CountriesLinq();
        }

        public static void ShowInfo(Car car)
        {
            Console.WriteLine("Модель: " + car.model + " <----> Номер: " + car.number + " <----> Скорость: " + car.speed + "\n");
        }
    }

    class Serialize
    {
        public static void Binary(Car car)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = new FileStream("BinaryCar_"+ car.model + ".dat", FileMode.Create))
            {
                binaryFormatter.Serialize(stream, car);
                stream.Close();
            }
            Console.WriteLine("Успешная сериализация: " + car.model);
        }
        public static Car BinaryDeserialize(Car car)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = new FileStream("BinaryCar_" + car.model + ".dat", FileMode.Open))
            {
                car = (Car)binaryFormatter.Deserialize(stream);
                stream.Close();
            }
            Console.WriteLine("Успешная десериализация: " + car.model);
            return car;
        }
        public static void SOAP(Car car)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream stream = new FileStream("SoapCar_" + car.model + ".soap", FileMode.Create))
            {
                soapFormatter.Serialize(stream, car);
                stream.Close();
            }
            Console.WriteLine("Успешная сериализация: " + car.model);
        }
        public static Car SOAPDeserialize(Car car)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream stream = new FileStream("SoapCar_" + car.model + ".soap", FileMode.Open))
            {
                car = (Car)soapFormatter.Deserialize(stream);
                stream.Close();
            }
            Console.WriteLine("Успешная десериализация: " + car.model);
            return car;
        }
        public static void JSON(Car car)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Car));
            using (Stream stream = new FileStream("JSONCar_" + car.model + ".json", FileMode.Create))
            {
                jsonSerializer.WriteObject(stream, car);
                stream.Close();
            }
            Console.WriteLine("Успешная сериализация: " + car.model);
        }
        public static Car JSONDeserialize(Car car)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Car));
            using (Stream stream = new FileStream("JSONCar_" + car.model + ".json", FileMode.Open))
            {
                car = (Car)jsonSerializer.ReadObject(stream);
                stream.Close();
            }
            Console.WriteLine("Успешная десериализация: " + car.model);
            return car;
        }
        public static void XML(Car car)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream stream = new FileStream("XMLCar_" + car.model + ".xml", FileMode.Create))
            {
                xmlSerializer.Serialize(stream, car);
                stream.Close();
            }
            Console.WriteLine("Успешная сериализация: " + car.model);
        }
        public static Car XMLDeserialize(Car car)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car));
            using (Stream stream = new FileStream("XMLCar_" + car.model + ".xml", FileMode.Open))
            {
                car = (Car)xmlSerializer.Deserialize(stream);
                stream.Close();
            }
            Console.WriteLine("Успешная десериализация: " + car.model);
            return car;
        }

        public static void XMLCollection(List<Car> cars)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));
            using (Stream stream = new FileStream("XMLCarCollection.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(stream, cars);
                stream.Close();
            }
            Console.WriteLine("Успешная сериализация CarsList");
        }
        public static List<Car> XMLDeserializeCollection(List<Car> cars)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));
            using (Stream stream = new FileStream("XMLCarCollection.xml", FileMode.Open))
            {
                cars = (List<Car>)xmlSerializer.Deserialize(stream);
                stream.Close();
            }
            Console.WriteLine("Успешная десериализация CarsList");
            return cars;
        }

    }

    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Population { get; set; }
    }

    class XmlLinq
    {
        public static void CountriesCreate()
        {
            XDocument xmlDocument = new XDocument();
            XElement Belarus = new XElement("Country");
            XAttribute Name = new XAttribute("name", "Беларусь");
            XElement Capital = new XElement("capital", "Минск");
            XElement Population = new XElement("population", "9.501.086");
            Belarus.Add(Name);
            Belarus.Add(Capital);
            Belarus.Add(Population);

            XElement Russia = new XElement("Country");
            Name = new XAttribute("name", "Россия");
            Capital = new XElement("capital", "Москва");
            Population = new XElement("population", "146.880.432");
            Russia.Add(Name);
            Russia.Add(Capital);
            Russia.Add(Population);

            XElement Germany = new XElement("Country");
            Name = new XAttribute("name", "Германия");
            Capital = new XElement("capital", "Берлин");
            Population = new XElement("population", "82.792.351");
            Germany.Add(Name);
            Germany.Add(Capital);
            Germany.Add(Population);

            XElement Poland = new XElement("Country");
            Name = new XAttribute("name", "Польша");
            Capital = new XElement("capital", "Варшава");
            Population = new XElement("population", "38.644.487");
            Poland.Add(Name);
            Poland.Add(Capital);
            Poland.Add(Population);

            XElement Countries = new XElement("Countries");
            Countries.Add(Belarus);
            Countries.Add(Russia);
            Countries.Add(Germany);
            Countries.Add(Poland);

            xmlDocument.Add(Countries);
            xmlDocument.Save("Countries.xml");
        }

        public static void CountriesLinq()
        {
            XDocument xDoc = XDocument.Load("Countries.xml");
            var AllInfo = from x in xDoc.Element("Countries").Elements("Country")
                          select new Country
                          {
                              Name = x.Attribute("name").Value,
                              Capital = x.Element("capital").Value,
                              Population = x.Element("population").Value
                          };

            Console.WriteLine("Вывод всей информации\n");
            foreach(var a in AllInfo)
            {
                Console.WriteLine($"Страна: {a.Name}");
                Console.WriteLine($"Столица: {a.Capital}");
                Console.WriteLine($"Население страны: {a.Population}\n");
            }

            var PopulationSortAll = from x in xDoc.Element("Countries").Elements("Country") orderby Convert.ToInt32(x.Element("population").Value.Replace(".", string.Empty))
                          select new Country
                          {
                              Name = x.Attribute("name").Value,
                              Capital = x.Element("capital").Value,
                              Population = x.Element("population").Value
                          };

            Console.WriteLine("Население по возрастанию\n");

            foreach (var a in PopulationSortAll)
            {
                Console.WriteLine($"Страна: {a.Name}");
                Console.WriteLine($"Столица: {a.Capital}");
                Console.WriteLine($"Население страны: {a.Population}\n");
            }

            var PopulationSort = from x in xDoc.Element("Countries").Elements("Country") where Convert.ToInt32(x.Element("population").Value.Replace(".",string.Empty)) >= 40000000 
                                 select new Country
                                 {
                                     Name = x.Attribute("name").Value,
                                     Capital = x.Element("capital").Value,
                                     Population = x.Element("population").Value
                                 };

            Console.WriteLine("Страны у которых население больше 40.000.000\n");

            foreach (var a in PopulationSort)
            {
                Console.WriteLine($"Страна: {a.Name}");
                Console.WriteLine($"Столица: {a.Capital}");
                Console.WriteLine($"Население страны: {a.Population}\n");
            }


        }
    }

    [Serializable]
    public class Info
    {
        public string model;
        public int number;
        public int speed;

        public Info()
        {

        }
        public Info(string m, int n, int s)
        {
            model = m;
            number = n;
            speed = s;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Модель - {model} <> Номер - {number} <> Скорость - {speed}");
        }

    }
    [Serializable]
    public class Car : Info
    {
        public Car()
        { }
        public Car(string m, int n, int s) : base(m, n, s)
        {

        }
    }
}
