using System;

namespace Lab8
{
    class Program
    {
        static void Main()
        {
            Password[] passwords = new Password[4];
            for (byte i = 0; i < 4; i++)
            {
                Console.WriteLine($"Введите {i+1}-й пароль:");
                passwords[i] = new();
                passwords[i].Pass = Console.ReadLine();
            }
            Console.WriteLine("--------------------------------------------------------");

            CollectionType<Password> myCollection = new();
            for (byte i = 0; i < 4; i++)
            {
                myCollection.Add(passwords[i]);
            }
            myCollection.Check();
            Console.WriteLine("--------------------------------------------------------");

            bool[] exepts =new bool[2]{ false, false };

            try
            {
                Password giveMe = myCollection.Delete(2);
                Console.WriteLine($"Извлечённый пароль {giveMe.Pass}");
                myCollection.Check();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.Source);
                exepts[0] = true;
            }
            finally
            {
                Console.WriteLine(exepts[0] == true ? "Исключение обработано" : "Исключение не обработано либо не произошло");
            }
            Console.WriteLine("--------------------------------------------------------");

            try
            {
                StandartTypes<int, double, byte> myTypes = new(1234, 123.4, 8); // обобщение для проверки типов
                myTypes.ShowTypes();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.Source);
                exepts[1] = true;
            }
            finally
            {
                Console.WriteLine(exepts[1] == true ? "Исключение обработано" : "Исключение не обработано либо не произошло");
            }
            Console.WriteLine("--------------------------------------------------------");

            myCollection.WriteToFile();
            myCollection.ReadFromFile();
            Console.ReadKey();
        }
    }
}
