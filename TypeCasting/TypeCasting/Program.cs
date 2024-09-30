using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {


        static void Main(string[] args)
        {
            bool converted_num1 = int.TryParse(Console.ReadLine(), out int result);
            bool converted_num2 = int.TryParse(Console.ReadLine(), out int result1);
            int add;
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());


            if (converted_num1 && converted_num2)
                add = result + result1;
            else
                Console.WriteLine("Unsuccessful conversio");
        }
    }
    }