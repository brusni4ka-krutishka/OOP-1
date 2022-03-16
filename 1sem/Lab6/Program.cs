using System;

namespace Lab6
{
    class Program
    {
        static void Main()
        {
            Printer printer = new("Canon 16", "Да", 15);
            Scanner scanner = new("Canon pixma", "Нет", 0);
            Computer computer = new ("Hyper PC", "Да", 45);
            Tablet tablet = new("Prestigio", "Да", 99);

            Console.WriteLine("_________________________ВЫВОД ЭЛЕМЕНТОВ ЧЕРЕЗ МАССИВ________________________");
            Console.WriteLine("-------------------------------------");
            Mechanism[] allmech = new Mechanism[]{ printer,scanner,computer,tablet};
            foreach (var item in allmech)
            {
                Printer2.IAmPrinting(item);
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("______________________________________________________________________________");


            Console.WriteLine($"Принтер есть принтер: {printer is Printer}");
            Console.WriteLine($"Планшет есть планшет: {tablet is Tablet}");
            Console.WriteLine($"Сканер есть техника: {scanner is Mechanism}\n");

            computer.Clone();                   // вызов метода у класса
            ((IAlive)computer).Clone();         // вызов метода у интерфейса
            Console.WriteLine("______________________________________________________________________________");

            Console.WriteLine("Lab6\nМетоды Контейнера: добавление, показ и удаление...");

            Container ag1 = new();
            ag1.Add();
            ag1.Show();
            ag1.Delete();

            Console.WriteLine("\nТехника младше 3-x лет:");
            object[] ObjectsList = new object[6];
            ObjectsList[0] = new Test_tube(3, 10, 100);
            ObjectsList[1] = new Test_tube(4, 12, 700);
            ObjectsList[2] = new Test_tube(2, 9, 890);
            ObjectsList[3] = new Test_tube(5, 13, 876);
            ObjectsList[4] = new Test_tube(1, 123, 700);
            ObjectsList[5] = new Test_tube(3, 10, 600);
            byte count=0;
            foreach (Test_tube can in ObjectsList)
            {
                if (can.life < 3)
                {
                    Console.WriteLine($"Партия колб №{count}: цена {can.cost}, кол-во {can.amount} штук.");
                    count++;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine("\nМетоды Контроллера...");
            ControlElement a = new(false, 5, 89);
            a.Status(); a.Switch();a.Status(); Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
