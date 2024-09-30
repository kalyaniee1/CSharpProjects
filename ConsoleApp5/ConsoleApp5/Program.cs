using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Rectangle
    {
        private double length, width;
        Rectangle(double l, double w) {
            this.length = l;
            this.width = w;
        }
        public double CalculateArea() {
            return length * width;
        }

        public double CalculatePerimeter() {
            return (length * 2) + (width * 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the rectangle:");
            double len = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width of the rectangle:");
            double len = Convert.ToDouble(Console.ReadLine());

        }
    }
}
