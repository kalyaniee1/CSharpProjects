using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "Sushant", 10000);
            manager.CalculateCTC();
            manager.displayData();

            Developer developer = new Developer(2, "Ayush", 12000);
            developer.CalculateCTC();
            developer.displayData();

            Tester tester = new Tester(3, "Sakshi", 15000);
            tester.CalculateCTC();
            tester.displayData();
            //Employee employee2 = new Developer ();
            //Employee employee3 = new Tester ();

        }
    }
}
