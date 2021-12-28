using System;
using Task1.Enums;
using Task1.Structs;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Key key1 = new Key(Note.C, Accidental.NoSign, Octave.Great);

            Console.WriteLine(key1);
        }
    }
}
