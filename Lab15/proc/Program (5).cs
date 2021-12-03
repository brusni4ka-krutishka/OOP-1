using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Threading;

namespace Laba15                            //15
{
    class Program
    {
        public static int num;
        public static Thread thread, thread_even, thread_odd;
        static AutoResetEvent AutoReset1 = new AutoResetEvent(true), AutoReset2 = new AutoResetEvent(true);
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine("<---------------> Задание 1 <--------------->");
            for(int i=0;i<processes.Length;i++)
            {
                try
                {
                    Console.WriteLine($"ID - {processes[i].Id}\tИмя - {processes[i].ProcessName}\tВремя создания - {processes[i].StartTime}\tПриоритет - {processes[i].PriorityClass}\tСостояние процесса - " + (processes[i].Responding ? "Run": "Stop"));
                }
                catch(Exception e)
                {
                    Console.WriteLine($"ID - {processes[i].Id}\tName - {processes[i].ProcessName}\tОшибка - {e.Message}");

                }
            }
            Console.WriteLine("\n\n\n<---------------> Задание 2 <--------------->\n");
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Имя: {domain.FriendlyName}");
            Console.WriteLine($"ID: {domain.Id}");
            Console.WriteLine($"Путь: {domain.BaseDirectory}");
            Console.WriteLine("\nВсе сборки\n");
            var Assemblies = from asm in domain.GetAssemblies() orderby asm.GetName().Name select asm;
            foreach(var a in Assemblies)
            {
                Console.WriteLine($"Имя - {a.GetName().Name}\tВерсия - {a.GetName().Version}");
            }
            AppDomain app = AppDomain.CreateDomain("Second Domain");
            app.DomainUnload += Domain_DomainUnload;
            app.AssemblyLoad += Domain_AssemblyLoad;


            Console.WriteLine($"\nДомен: {app.FriendlyName}");
            app.Load("System.Data");
            Assembly[] assemblies = app.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine($"Имя - {asm.GetName().Name}");
            }
            AppDomain.Unload(app);

            Console.WriteLine("\n\n\n<---------------> Задание 3 <--------------->\n");
            Console.Write("Введите количество простых чисел: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            thread = new Thread(new ThreadStart(WriteSimpleNum));
            thread.Name = "MyThread";
            thread.Start();
            thread.Join();

            Console.WriteLine("\n\n\n<---------------> Задание 4 <--------------->\n");
            Console.Write("Введите количество чисел: ");
            num = Convert.ToInt32(Console.ReadLine());
            // b i) Сначала четные потом нечетные
            thread_even = new Thread(new ThreadStart(Even_Num_Write));
            thread_odd = new Thread(new ThreadStart(Odd_Num_Write));
            thread_even.Start();
            thread_odd.Priority = ThreadPriority.AboveNormal; // a) изменение приоритета
            thread_odd.Start();
            thread_odd.Join();
            // b ii) одно четное, одно нечетное
            Console.WriteLine("\nОдно четное, одно нечетное\n");
            thread_even = new Thread(new ThreadStart(Even_Num_Show));
            thread_odd = new Thread(new ThreadStart(Odd_Num_Show));
            thread_even.Start();
            thread_odd.Start();
            thread_even.Join();
            thread_odd.Join();
            Console.WriteLine("\n\n\n<---------------> Задание 5 <--------------->\n");
            int count = 10;
            Console.WriteLine("Использование таймера");
            Timer timer = new Timer(Timer_Count, count, 0, 1000);
            Console.ReadLine();
        }

        static void Timer_Count(object obj)
        {
            Console.WriteLine($"Текущие дата и время: {DateTime.Now}");
        }

        public static void Even_Num_Show()
        {
            for (int i = 0; i <= num; i++)
            {
                AutoReset2.WaitOne();
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                AutoReset1.Set();
            }
        }

        public static void Odd_Num_Show()
        {
            for (int i = 0; i <= num; i++)
            {
                AutoReset1.WaitOne();
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                }
                AutoReset2.Set();
            }
            Console.WriteLine();
        }


        public static void Even_Num_Write()
        {
            FileStream fileStream = new FileStream("Even and Uneven.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(fileStream);
            Console.WriteLine("\nЧетные числа\n");
            writer.WriteLine("\nЧетные числа\n");
            for(int i = 0; i<num;i++)
            {
                if(i%2 == 0)
                {
                    Console.Write(i + ", ");
                    writer.Write(i + ", ");
                }
            }
            Console.WriteLine();
            writer.WriteLine();
            writer.Close();
            fileStream.Close();
        }
        public static void Odd_Num_Write()
        {
            thread_even.Join();
            FileStream fileStream = new FileStream("Even and Uneven.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fileStream);
            Console.WriteLine("\n\nНечетные числа\n");
            writer.WriteLine("\n\nНечетные числа\n");
            for (int i = 0; i < num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                    writer.Write(i + ", ");
                }
            }
            writer.Close();
            fileStream.Close();
            Console.WriteLine();
        }
        public static void WriteSimpleNum()
        {
            StreamWriter writer = new StreamWriter("SimpleNum.txt");
            for(int i=0;i<num;i++)
            {
                if(IsSimple(i))
                {
                    Console.Write(i + ", ");
                    writer.Write(i + ", ");
                }
                if (i == num / 3)
                {
                    try
                    {
                        thread.Abort();
                    }
                    catch
                    {
                        Console.Write("Поток остановлен ");
                        Thread.ResetAbort();
                        Console.Write("Поток возабновлен ");
                    }
                }
            }
            
            Console.WriteLine();
            writer.Close();
            Console.WriteLine("\nИнформация о потоке");
            Console.WriteLine($"ID - {thread.ManagedThreadId}  Имя - {thread.Name}  Статус - {thread.ThreadState}  Приоритет - {thread.Priority}");
        }

        public static bool IsSimple(int N)
        {
            for(int i =2;i<N/2;i++)
            {
                if(N%i==0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Domain_DomainUnload(object sender, EventArgs e)
        {
            Console.WriteLine("\nДомен выгружен\n");
        }

        private static void Domain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine("\nСборка загружена\n");
        }
    }
}
