using System;

namespace Lab5
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
            Console.ReadKey();
        }
    }
}
