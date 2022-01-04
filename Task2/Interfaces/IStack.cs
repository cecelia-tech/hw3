using System;
using Task2.ExtencionMethods;
namespace Task2.Interfaces
{
    public interface IStack<T>
    {
        public void Push(T item);
        public T Pop();
        public bool IsEmpty();
    }
}
