using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void PrintDimensions(Rectangle rectangle, string rectangleType)
        {
            Console.WriteLine(rectangleType);
            Console.WriteLine("Color: "+rectangle.Color);
            Console.WriteLine("Height:" + rectangle.Height);
            Console.WriteLine("Width:" + rectangle.Width);
            Console.WriteLine("Area:" + rectangle.CalculateArea());
        }
        static void Main(string[] args)
        {
            
            Rectangle small_rectangle=new Rectangle(5.5F,6,"Purple");
            Rectangle medium_rectangle = new Rectangle(6.5F, 7);
            Rectangle big_rectangle = new Rectangle();
            
            PrintDimensions(small_rectangle,"Small rectangle");

            PrintDimensions(medium_rectangle, "Medium rectangle");
           
            PrintDimensions(big_rectangle, "Big rectangle");
        }
    }
}
