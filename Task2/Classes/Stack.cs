using System;
using System.Collections;
using System.Collections.Generic;
using Task2.Interfaces;

namespace Task2.Classes
{
    public class Stack<T> : IStack<T>
    {
        public int Index { get; set; }

        public T[] stack = new T[10];

        public T this[int index]
        {
            // The arr object will throw IndexOutOfRange exception.
            get => stack[index];
            set => stack[index] = value;
        }

        public bool IsEmpty()
        {
            return Index == 0;
        }

        public T Pop()
        {
            return stack[--Index];
        }

        public void Push(T number)
        {
            stack[Index++] = number;
        }
    }
}
