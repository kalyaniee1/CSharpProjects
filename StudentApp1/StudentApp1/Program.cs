using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp1
{
    internal class Program
    {
        int rollno;
        string name;
        float cgpa;

        public void validateData()
        {
            bool flag = false;
            Console.WriteLine("Enter Student details:");
            while (flag == false)
            {
                Console.WriteLine("Roll number:");
                rollno = Convert.ToInt16(Console.ReadLine());
                if (rollno <= 0)
                {
                    Console.WriteLine("Enter valid roll number:");
                }
                else { flag = true; }
            }
            flag = false;
            while (flag == false)
            {
                Console.WriteLine("Name:");
                name = Console.ReadLine();
                if (name.Length < 5)
                {
                    Console.WriteLine("Enter valid name");
                }
                else { flag = true; }
            }
            flag = false;

            while (flag == false)
            {
                Console.WriteLine("GGPA:");
                cgpa = float.Parse(Console.ReadLine());
                if (cgpa < 1 || cgpa > 10 )
                {
                    Console.WriteLine("Enter valid CGPA:");
                }
                else { flag = true; }
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.validateData();
            StudentApp studentApp = new StudentApp(program.rollno,program.name,program.cgpa);
            studentApp.displayData();
        }
    }
}
