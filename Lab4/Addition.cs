using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    public class Owner
    {
        readonly private int id;
        readonly private string name;
        readonly private string org;

        public Owner(int id, string name, string org)
        {
            this.id = id;
            this.name = name;
            this.org = org;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID:{0}\nИмя:{1}\nОрганизация:{2}", id, name, org);
        }
    }
    public class Date // класс Date
    {
        readonly private int day;
        readonly private int month;
        readonly private int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void GetDate()
        {
            Console.WriteLine("Год:{0}\nМесяц:{1}\nДень:{2}\n", year, month, day);
        }
    }
}
