using System;
using Task2.Classes;
using Task2.ExtencionMethods;
//using System.Collections;

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
            //st.Clear();

            //Console.WriteLine("b");
            Console.WriteLine(st.Pop());

            Console.WriteLine("printing first stack");
            foreach (var item in st.stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Printing reversed stack");
            Reverse.Reverse2(st.stack);
            st.Reverse2();
        }
    }
}
