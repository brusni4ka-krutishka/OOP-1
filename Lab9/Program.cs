<<<<<<< HEAD
﻿using System;

namespace Lab9
{
    public delegate void Attack(object obj, EventArgs args);
    public delegate void Heal(object obj, EventArgs args);
    public delegate void Apocalypse(object obj, EventArgs args);
    public delegate void BeChange(string str);
    class Program
    {
        static void Main()
        {
            BeChange Message = (str) => Console.WriteLine(str);

            Game game = new();

            Сharacter char1 = new("Орк", 100, 15),
                char2 = new("Эльф", 120, 10);


            char1.NewCharacter();
            char1.RegChange(Message);
            char1.NewCharacter();
            
            game.Attacking += char1.Attack;
            game.Attacking += char2.Attack;
            game.Attacking += char2.Attack;
            game.Attacking += char2.Attack;

            game.DidAttack();

            game.Healing += char2.Heal;
            game.DidHealing();

            Console.WriteLine("Да начнётся апокалипсис!");
            game.Apocalypsing += char1.Apocalypse;
            game.Apocalypsing += char2.Apocalypse;
            game.DidApocalypse();
            Console.WriteLine("Конец игры!\n");
            //////////////////////////////////////

            string str1 = "Hello! My name is Eugene";

            Console.WriteLine("Делаем все буквы строчными");
            Console.WriteLine(ChangeString.MyToLower(str1));
            Console.WriteLine();

            Console.WriteLine("Добавляем в конце букву g");
            Console.WriteLine(ChangeString.AddLetter(str1, 'g'));
            Console.WriteLine();

            Console.WriteLine("Меняем e на E");
            Console.WriteLine(ChangeString.Ii(str1));
            Console.WriteLine();

            Console.WriteLine("Делаем все буквы заглавными");
            Console.WriteLine(ChangeString.MyToUpper(str1));
            Console.WriteLine();

            Console.WriteLine("Добавляем в конце букву E");
            Console.WriteLine(ChangeString.AddPoint(str1));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
=======
﻿using System;

namespace Lab9
{
    public delegate void Attack();
    public delegate void Heal();
    public delegate void Apocalypse();
    public delegate void BeChange(string str);
    class Program
    {
        static void Main()
        {
            Game game = new();

            Сharacter char1 = new("Орк", 100, 15),
                char2 = new("Эльф", 120, 10);


            char1.NewCharacter();
            char1.RegChange((str) => Console.WriteLine(str));
            char1.NewCharacter();
            
            game.Attacking += char1.Attack;
            game.Attacking += char2.Attack;
            game.Attacking += char2.Attack;
            game.Attacking += char2.Attack;

            game.DidAttack();

            game.Healing += char2.Heal;
            game.DidHealing();

            Console.WriteLine("Да начнётся апокалипсис!");
            game.Apocalypsing += char1.Apocalypse;
            game.Apocalypsing += char2.Apocalypse;
            game.DidApocalypse();
            Console.WriteLine("Конец игры!\n");
            //////////////////////////////////////

            string str1 = "Hello! My name is Eugene";

            Console.WriteLine($"Делаем все буквы строчными\n{ChangeString.MyToLower(str1)}\n");
            Console.WriteLine($"Добавляем в конце букву g\n{ChangeString.AddLetter(str1, 'g')}\n");
            Console.WriteLine($"Меняем e на E\n{ChangeString.Ii(str1)}\n");
            Console.WriteLine($"Делаем все буквы заглавными\n{ChangeString.MyToUpper(str1)}\n");
            Console.WriteLine($"Добавляем в конце букву E\n{ChangeString.AddPoint(str1)}\n");

            Console.ReadKey();
        }
    }
}
>>>>>>> 78a6fa9ceccb1b5315eaa7e8a64ba05cf94990ff
