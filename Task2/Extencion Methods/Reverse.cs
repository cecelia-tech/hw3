using System;
using Task2.Classes;
using Task2.Interfaces;

namespace Task2.ExtencionMethods
{
    public static class Extension
    {
        public static Stack<T> Reverse<T>(this IStack<T> stack)
        {
            var s = stack as Stack<T>;

            Stack<T> newStack = new Stack<T>();
             
            int stackLength = s.Index;

            for (int i = 0; i < s.Index; i++)
            {
                newStack.Push(s.stack[--stackLength]);
            }

            return newStack;
        }
    }
}
