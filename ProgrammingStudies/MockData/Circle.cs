using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingStudies.MockData
{
    public class Circle
    {

        public int Radius { get; set; }
        public int Diameter { get => Radius * 2; }
        public double Area { get => Math.PI * Radius * Radius; }
        public double Circumference { get => Math.PI * 2 * Radius; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void Deconstruct(out int radius, out int diameter, out double area, 
            out double circumference)
        {
            radius = Radius;
            diameter = Diameter;
            area = Area;
            circumference = Circumference;
        }

        public override string ToString()
        {
            return $"Circle\n Radius: {Radius}, Diameter: {Diameter}, Area: {Area}, Circumference: {Circumference}";
        }

    }
}
