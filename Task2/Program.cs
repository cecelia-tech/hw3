using System;
using Task2.Classes;
using Task2.ExtencionMethods;
using Task2.Interfaces;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            Console.WriteLine("Printing reversed stack");

            IStack<int> st2 = st.Reverse();

            for (int i = 0; i < st2.Index; i++)
            {
                Console.WriteLine(st2[i]);
            }
        }
    }
}
