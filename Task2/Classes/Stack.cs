using System;
using System.Text;
using Task2.Interfaces;

namespace Task2.Classes
{
    public class Stack<T> : IStack<T>
    {
        private const int STACK_SIZE = 5;
        private int index = default;
        public int Index { get { return index; } }
        public T[] stack = new T[STACK_SIZE];

        public bool IsEmpty()
        {
            return index == 0;
        }

        public T Pop()
        {
            return index == 0 ? default : stack[--index];
        }

        public void Push(T number)
        {
            if (index == STACK_SIZE)
            {
                // does nothing
                return;
            }

            stack[index++] = number;
        }

        public override string ToString()
        {

            StringBuilder stackToString = new StringBuilder();

            for (int i = 0; i < index; i++)
            {
                stackToString.Append(stack[i]).Append('\n');
            }
            return stackToString.ToString();
        }
    }
}
