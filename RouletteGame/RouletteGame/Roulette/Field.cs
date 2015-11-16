using System;

namespace RouletteGame.Roulette
{
    public class Field
    {
        public const uint Red = 0;
        public const uint Black = 1;
        public const uint Green = 1;

        private uint _number;
        public uint Number
        {
            get { return _number; }
            private set
            {
                if (value <= 36) _number = value;
                else throw new FieldException($"Number {value} not a valid field number");
            }
        }

        private uint _color;
        public uint Color
        {
            get { return _color; }
            private set
            {
                if (value == Red || value == Black || value == Green) _color = value;
                else throw new FieldException($"Color {value} not a valid color. Must be either Red or Black");
            }
        }

        public bool Even => Number % 2 == 0;

        // Constructor
        public Field(uint number, uint color)
        {
            Number = number;
            Color = color;
        }

        public override string ToString()
        {
            string colorString;

            switch (Color)
            {
                case Red: colorString = "red"; break;
                case Black: colorString = "black"; break;
                default: colorString = "green"; break;
            }

            return $"[{_number}, {colorString}]";
        }
    }

    public class FieldException : Exception
    {
        public FieldException(string s) : base(s)
        {
        }
    }
}
