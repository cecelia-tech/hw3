using System;
//using System.Collections.Generic;
using Task2.ExtencionMethods;
namespace Task2.Interfaces
{
    public interface IStack<T>
    {
        public int Index { get; set; }
        public void Push(T item);
        public T Pop();
        public bool IsEmpty();
        //void Log(string s) => Console.WriteLine(s);
        public T this[int index]
        {
            get;
            set;
        }
    }
}
