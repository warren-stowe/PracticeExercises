using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.MockData
{
    public class Square
    {
        public int Side { get; set; }

        public int Area { get => Side * Side; }

        public int Perimeter { get => Side * 4; }

        public override string ToString()
        {
            return $"Square\nSide: {Side}, Area: {Area}, Perimeter: {Perimeter}";
        }

        public Square(int side)
        {
            Side = side;
        }

        public void Deconstruct(out int side, out int area, out int perimeter)
        {
            side = Side;
            area = Area;
            perimeter = Perimeter;
        }
    }
}
