using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    //A class shoud be open for extension, but closed for modification

    //Problem
    //public class AreaCalculator
    //{
    //    public double CalculateArea(object shape)
    //    {
    //        if (shape is Rectangle r)
    //        {
    //            return r.Width * r.Height;
    //        }
    //        else if (shape is Circle c)
    //        {
    //            return Math.PI * c.Radius * c.Radius;
    //        }

    //        return 0;
    //    }
    //}

    //public class Rectangle
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //}

    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}


    //Solution
    public interface IShape
    {
        double CalculateArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    public class AreaCalculator
    {
        public double TotalArea(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.CalculateArea();
            }
            return area;
        }
    }

}
