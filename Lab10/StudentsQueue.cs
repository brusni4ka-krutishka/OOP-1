using System;
using System.Collections.Generic;

namespace Lab10
{
    public interface IEnumerable<T>
    {
        IEnumerator<T> GetEnumerator();
    }
    class StudentQueue:IEnumerable <Student>
    {
        readonly Queue<Student> StdntQueue = new();

        public StudentQueue(params Student[] values)
        {
            foreach (Student item in values)
                Add(item);
        }
       public Queue<Student> Add(Student item)
        {
            StdntQueue.Enqueue(item);
            return StdntQueue;
        }
        public Queue<Student> RemoveFirst()
        {
            StdntQueue.Dequeue();
            return StdntQueue;
        }
        public Queue<Student> Clear()
        {
            StdntQueue.Clear();
            return StdntQueue;
        }
        public void Show()
        {
            if(StdntQueue.Count!=0)
                foreach (var item in StdntQueue)
                {
                    Console.WriteLine(item.ToString());
                }
            else
                Console.WriteLine("Очередь пуста");
        }
        public bool Find(Student item)
        {
            return StdntQueue.Contains(item);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return StdntQueue.GetEnumerator();
        }
    }
}
