using System;
using System.Diagnostics.CodeAnalysis;
using Task1.Enums;

namespace Task1.Structs
{
    public struct Key : IComparable<Key>
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
            var _symbol = Accidental.Sharp == _accidental? "#" :
                         Accidental.Flat == _accidental ? "♭" : "";

            return $"{_note}{_symbol} ({_octave})";
        }

        public override bool Equals(object obj)
        {
            var key = (Key)obj;

            if (_octave != key._octave)
            {
                return false;
            }

            if (key._note == _note &&
                key._accidental == _accidental
                )
            {
                return true;
            }

            //deals with regular sharp and flat
            if ((Convert.ToChar(_note) + 1 == Convert.ToChar( key._note) &&
                _accidental == Accidental.Sharp && key._accidental == Accidental.Flat) ||
                (Convert.ToChar(_note) - 1 == Convert.ToChar(key._note) &&
                _accidental == Accidental.Flat && key._accidental == Accidental.Sharp)
                )
            {
                return true;
            }

            //deals with one flat and other one no sign
            if ((Convert.ToChar(_note) + 1 == Convert.ToChar(key._note) &&
                _accidental == Accidental.NoSign && key._accidental == Accidental.Flat) ||
                (Convert.ToChar(_note) - 1 == Convert.ToChar(key._note) &&
                _accidental == Accidental.Flat && key._accidental == Accidental.NoSign)
                )
            {
                return true;
            }

            //deals with A and G

            if ((_note == Note.G &&
                key._note == Note.A &&
                _accidental == Accidental.Sharp && key._accidental == Accidental.Flat) ||
                (_note == Note.A &&
                key._note == Note.G &&
                _accidental == Accidental.Flat && key._accidental == Accidental.Sharp)
                )
            {
                return true;
            }

            return false;
        }

        public int CompareTo(Key other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            return _note.CompareTo(other._note);
        }
    }
}
