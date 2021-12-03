 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using lab5;

namespace Serializ                              //14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Атрибут Serialize
            Ellipse ellipse1 = new Ellipse("Эллипс1", 123123, 100, "Голубой");
            Checkbox checkbox1 = new Checkbox("Чекбокс1", 145145, 150, "Серый", 150, true);
            Rectangle rectangle1 = new Rectangle("Прямоугольник1", 789789, 220, "Розовый", 125);
            Button button1 = new Button("Радиокнопка1", 159159, 300, "Черный", 300, false);
            Figure[] figures = new Figure[] { ellipse1, checkbox1, rectangle1, button1 };


            Console.WriteLine("----------------------------------------------------------------");
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("../figure.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ellipse1);
                Console.WriteLine("Объект сериализован");
            }


            using (FileStream fs = new FileStream("../figure.dat", FileMode.OpenOrCreate))
            {
                Ellipse newEllipse = (Ellipse)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя фигуры: {newEllipse.Figurename}   ID: {newEllipse.Id}   Цвет: {newEllipse.Color}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            SoapFormatter formatter2 = new SoapFormatter();
            using (FileStream fs = new FileStream("../figure2.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, checkbox1);
                Console.WriteLine("Объект сериализован");
            }


            using (FileStream fs = new FileStream("../figure2.dat", FileMode.OpenOrCreate))
            {
                Checkbox newCheckbox = (Checkbox)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя фигуры: {newCheckbox.Figurename}   ID: {newCheckbox.Id}   Цвет: {newCheckbox.Color}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            DataContractJsonSerializer formatter3 = new DataContractJsonSerializer(typeof(Rectangle));

            using (FileStream fs = new FileStream("../figure3.json", FileMode.OpenOrCreate))
            {
                formatter3.WriteObject(fs, rectangle1);
                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("../figure3.json", FileMode.OpenOrCreate))
            {
                Rectangle newRectangle = (Rectangle)formatter3.ReadObject(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя фигуры: {newRectangle.Figurename}   ID: {newRectangle.Id}   Цвет: {newRectangle.Color}");
            }

            Console.WriteLine("----------------------------------------------------------------");

            BinaryFormatter formatter5 = new BinaryFormatter();

            using (FileStream fs = new FileStream("../figures.dat", FileMode.OpenOrCreate))
            {
                formatter5.Serialize(fs, figures);
                Console.WriteLine("Массив объектов сериализован");
            }


            using (FileStream fs = new FileStream("../figures.dat", FileMode.OpenOrCreate))
            {
                Figure[] newFighters = (Figure[])formatter.Deserialize(fs);

                Console.WriteLine("Массив объектов десериализован");
                foreach (Figure item in newFighters)
                {
                    Console.WriteLine($"Имя фигуры: {item.Figurename}   ID: {item.Id}   Цвет: {item.Color}");
                }                
            }

            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Первый xml запрос (выбор имён):");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../XMLFile1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes1 = xRoot.SelectNodes("figure");

            foreach (XmlNode n in childnodes1)
                Console.WriteLine(n.SelectSingleNode("@name").Value);

            Console.WriteLine("Второй xml запрос (получаем цвет):");
            XmlNodeList childnodes2 = xRoot.SelectNodes("//figure/color");

            foreach (XmlNode n in childnodes2)
                Console.WriteLine(n.InnerText);

            Console.WriteLine("Третий xml запрос (конкретный id):");
            XmlNode childnode3 = xRoot.SelectSingleNode("figure[id='123123']");
            if (childnode3 != null)
                Console.WriteLine(childnode3.OuterXml);

            Console.WriteLine("----------------------------------------------------------------");

            XDocument document = new XDocument();
            XElement root = new XElement("countries");

            XElement country1 = new XElement("country");
            root.Add(country1);
            XAttribute number1 = new XAttribute("number", "1");
            country1.Add(number1);
            XElement CounryName1 = new XElement("name", "Belarus");
            country1.Add(CounryName1);
            XElement square1 = new XElement("area", "207595 km2");
            country1.Add(square1);
            XElement population1 = new XElement("population", "10M");
            country1.Add(population1);

            XElement country2 = new XElement("country");
            root.Add(country2);
            XAttribute number2 = new XAttribute("number", "2");
            country2.Add(number2);
            XElement CounryName2 = new XElement("name", "Russia");
            country2.Add(CounryName2);
            XElement square2 = new XElement("area", "17100000 km2");
            country2.Add(square2);
            XElement population2 = new XElement("population", "144M");
            country2.Add(population2);
            document.Add(root);

            document.Save("../Countries.xml");
            Console.WriteLine("Документ создан при помощи LINQ to XML");

            Console.WriteLine("----------------------------------------------------------------");
           
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("../Countries.xml");
            XmlElement Root = xdoc.DocumentElement;

            Console.WriteLine("Первый xml запрос (выбор имён):");
            XmlNodeList childnodes4 = Root.SelectNodes("country");
            foreach (XmlNode n in childnodes4)
                Console.WriteLine(n.SelectSingleNode("name").InnerText);

            Console.WriteLine("Второй xml запрос (получаем площадь):");
            XmlNodeList childnodes5 = Root.SelectNodes("//country/area");
            foreach (XmlNode n in childnodes5)
                Console.WriteLine(n.InnerText);

            Console.WriteLine("Третий xml запрос (нужное население):");
            XmlNode childnode6 = Root.SelectSingleNode("country[population='144M']");
            if (childnode6 != null)
                Console.WriteLine(childnode6.OuterXml);

            Console.ReadKey();
        }
    }
}

