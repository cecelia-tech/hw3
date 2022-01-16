using System;
using Task2.Classes;
using Task2.Interfaces;

namespace Task2.ExtencionMethods
{
    public static class Extension
    {
        public static IStack<T> Reverse<T>(this IStack<T> stack)
        {
            IStack<T> newStack = new Stack<T>();
            
            int stackLength = stack.Index;

            for (int i = 0; i < stack.Index; i++)
            {
                newStack[i] = stack[--stackLength];
            }

            newStack.Index = stack.Index;

            return newStack;
        }
    }
}
