using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files                             //13
{


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите имя диска (например D, C...):");
            string DriveName = Console.ReadLine();

            GEVLog.GEVDiskInfo.ShowFreeSpace(DriveName);
            GEVLog.GEVDiskInfo.ShowFileSystem(DriveName);
            GEVLog.GEVDiskInfo.AllInfo();

            Console.WriteLine("Введите путь к файлу по которому будем получать информацию:");
            string path1 = Console.ReadLine();         // X:\\Проекты Visual Studio\\repos\\лаба13\\observer.txt
            GEVLog.GEVFileInfo.ShowFilePath(path1);
            GEVLog.GEVFileInfo.ShowFileSizeExtAndName(path1);
            GEVLog.GEVFileInfo.ShowCreationTime(path1);

            Console.WriteLine("Введите путь к папке по которой будем получать информацию:"); // X:\\Проекты Visual Studio\\repos\\лаба13\\observer.txt
            string path2 = Console.ReadLine();
            GEVLog.GEVDirInfo.NumberOfFiles(path2);
            GEVLog.GEVDirInfo.ListOfDirectory(path2);
            GEVLog.GEVDirInfo.ParentDirectory(path2);

            GEVLog.GEVFileManager.Task_a();


            Console.WriteLine("Введите путь к папке, из которой будут скопированы все файлы с расширением docx:"); // X:\\Проекты Visual Studio\\repos\\лаба13
            string path3 = Console.ReadLine();

            GEVLog.GEVFileManager.Task_b(path3);

            GEVLog.GEVFileManager.Task_c();

            GEVLog.GEVFileManager.ForObserver.ObservActiones();

        }
    }

}
