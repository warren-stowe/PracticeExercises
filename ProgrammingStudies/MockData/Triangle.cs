using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.MockData
{
    public class Triangle
    {
        public int Base { get; set; }
        public int FirstSide { get; set; }
        public int SecondSide { get; set; }
        public int Height { get; set; }
        public double Area { get => (0.5 * (double)Base) * Height;}
        public int Perimeter { get => Base + FirstSide + SecondSide; }

        public Triangle(int height, int @base, int firstSide, int secondSide)
        {
            bool checkSide1, checkSide2, checkSide3;

            checkSide1 = (@base + firstSide) > secondSide;
            checkSide2 = (firstSide + secondSide) > @base;
            checkSide3 = (@base + secondSide) > firstSide;

            if (checkSide1 && checkSide2 && checkSide3)
            {
                Base = @base;
                FirstSide = firstSide;
                SecondSide = secondSide;
                Height = height;
            } else
            {
                throw new ArgumentException("Invalid entries for a triangle");
            }
        }

        public void Deconstruct(out int @base, out int height, out int firstSide, out int secondSide,
            out int perimeter, out double area)
        {
            @base = Base;
            height = Height;
            firstSide = FirstSide;
            secondSide = SecondSide;
            perimeter = Perimeter;
            area = Area;
        }

        public override string ToString()
        {
            return $"Triangle\n Base: {Base}, Height: {Height}, Area: {Area}, Perimeter: {Perimeter}";
        }

    }
}
