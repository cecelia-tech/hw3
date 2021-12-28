using System;
using Task1.Enums;

namespace Task1.Structs
{
    public struct Key
    {
        readonly Octave _octave;
        readonly Note _note;
        readonly Accidental _accidental;

        public Key(Note note, Accidental accidental, Octave octave)
        {
            _octave = octave;
            _note = note;
            _accidental = accidental;
        }

        public override string ToString()
        {
            var result = Accidental.Sharp == _accidental? "#" :
                         Accidental.Flat == _accidental ? "♭" : "";

            return $"{_note}{result} ({_octave})";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
