using System;
using Task2.Classes;
using Task2.ExtencionMethods;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(1);
            st.Push(2);
            st.Push(3);

            Console.WriteLine("Printing reversed stack");

            Stack<int> st2 = st.Reverse();

            for (int i = 0; i < st2.Index; i++)
            {
                Console.WriteLine(st2.stack[i]);
            }

            Stack<string> st3 = new Stack<string>();

            st3.Push("1");
            st3.Push("2");
            st3.Push("3");
            st3.Push("4");
            st3.Push("5");
            st3.Push("6");
            st3.Push("7");
            st3.Push("8");
            st3.Push("9");
            st3.Push("10");
            st3.Push("11");
            st3.Push("12");
            //Console.WriteLine(st3.Pop()); 

            Console.WriteLine("Printing reversed st3");

            Stack<string> st4 = st3.Reverse();

            for (int i = 0; i < st4.Index; i++)
            {
                Console.WriteLine(st4.stack[i]);
            }
        }
    }
}
