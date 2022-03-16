using System;
using System.Diagnostics;

namespace Lab7
{
    class Program
    {
        static void Main()
        {
            try
            {

                Printer printer = new("Canon 16", "Да", 15);
                Scanner scanner = new("Canon pixma", "Нет", 0);
                Computer computer = new("Hyper PC", "Да", 45);
                Tablet tablet = new("Prestigio", "Да", 99);

                Console.WriteLine("_________________________ВЫВОД ЭЛЕМЕНТОВ ЧЕРЕЗ МАССИВ________________________");
                Console.WriteLine("-------------------------------------");
                Mechanism[] allmech = new Mechanism[] { printer, scanner, computer, tablet };
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


                Printer printer2 = new("Canon 16", "Да", 15);
                Scanner scanner2 = new("Canon pixma", "Нет", 0);
                Computer computer2 = new("Hyper PC", "Да", 45);
                Tablet tablet2 = new("Prestigio", "Да", 99);

                Mechanism[] figures = new Mechanism[] { printer2, scanner2, computer2, tablet2 };
                Console.WriteLine("---------------------------------------------------------------------");
                try
                {
                    printer2.Name = "Epson";
                    Console.WriteLine(printer2.Name);
                }

                catch (WrongName ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");


                try
                {
                    scanner2.Count = 0;
                    Console.WriteLine(scanner2.Count);
                }

                catch (WrongCostValue ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }

                try
                {
                    Console.WriteLine(figures[6].Available);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }
                Console.WriteLine("---------------------------------------------------------------------");

                try
                {
                    object obj = printer2.Name;
                    int name = (int)obj;

                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");
                }

                Console.WriteLine("---------------------------------------------------------------------");

                try
                {
                    byte countHashCode = (byte)(5 / scanner2.Count);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{ex.Message}\n{ex.Source}\n{ex.StackTrace}");

                }

            }
            catch (Exception)
            {
                Console.WriteLine("HI! I'm an Exception");
            }
            finally
            {
                Console.WriteLine("\nFinally-block");
                //Debug.Assert(4<=2);
                Console.ReadKey();
            }
        }
    }
}