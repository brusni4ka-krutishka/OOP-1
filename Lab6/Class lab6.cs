using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Tech
    {

    }
    public class Test_tube:Tech
    {
        public Test_tube(byte life,byte amount, short cost )
        {
            this.life = life;

            this.amount = amount;
            this.cost = cost;
        }
        public  short life;
        public  byte amount;
        public  short cost;
    }
    public class MicroScope : Tech
    {
        public MicroScope(byte life, byte amount, short cost)
        {
            this.life = life;
            this.amount = amount;
            this.cost = cost;
        }
        public byte life;
        public byte amount;
        public short cost;
    }

     partial class ControlElement
    {

        readonly int id;
        readonly int size;
        public bool IsActive { get; set; }
        public ControlElement Next { get; set; }
        public ControlElement(bool isAct, int id, int size)
        {
            this.IsActive = isAct;
            this.id = id;
            this.size = size;
        }
        public ControlElement NextElement()
        {
            return this.Next;
        }
        public void Switch()
        {
            if (IsActive)
            {
                IsActive = false;
            }
            else
            {
                IsActive = true;
            }
        }
        public void Status()
        {
            Console.WriteLine($"Element is {this.GetType()}. Is active = {IsActive}. Id = {id}. Size = {size}");
        }
        public override string ToString()
        {
            return $"Объект типа {this.GetType()}";
        }
    }
    public class Container
    {
        readonly object[] ObjectsList = new object[6];
        byte count = 0;
       
        public void Add()
        {
            if (count == 0)
            {
                ObjectsList[count] = new Test_tube(3, 10, 100);
                count++;
            }
            if (count == 1)
            {
                ObjectsList[count] = new Test_tube(4, 12, 700);
                count++;
            }
            if (count == 2)
            {
                ObjectsList[count] = new MicroScope(2, 9, 890);
                count++;
            }
            if (count == 3)
            {
                ObjectsList[count] = new Test_tube(5, 13, 876);
                count++;
            }
            if (count == 4)
            {
                ObjectsList[count] = new MicroScope(1, 123, 700);
                count++;
            }
            if (count == 5)
            {
                ObjectsList[count] = new MicroScope(3, 10, 600);
                count++;
            }
        }

        public void Delete()
        {
            count = 0;
            while (count < 6)
            {
                ObjectsList[count] = null;
                count++;
            }
        }
        public void Show()
        {
            count = 0;
            while (count < 6)
            {
                Console.WriteLine(ObjectsList[count]);
                count++;
            }
        }
    }
}
