using System;
using Task2.Interfaces;

namespace Task2.ExtencionMethods
{
    public static class Reverse
    {
        public static IStack<T>[] Reverse2<T>(this IStack<T>[] stack)
        {
            int stackLength = stack.Length;

            IStack<T>[] newStack = new IStack<T>[stack.Length];
            
            for (int i = 0; i < stack.Length; i++)
            {
                newStack[i] = stack[stackLength--];
            }
            
            return newStack;
        }
    }
}
