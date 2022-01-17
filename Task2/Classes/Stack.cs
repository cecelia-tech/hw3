using System;
using Task2.Interfaces;

namespace Task2.Classes
{
    public class Stack<T> : IStack<T>
    {
        public int Index { get; private set; }

        public T[] stack = new T[10];

        public bool IsEmpty()
        {
            return Index == 0;
        }

        public T Pop()
        {
            return Index == 0 ? default : stack[--Index];
        }

        public void Push(T number)
        {
            if (Index == stack.Length)
            {
                // does nothing
                return;
            }

            stack[Index++] = number;
        }
    }
}
