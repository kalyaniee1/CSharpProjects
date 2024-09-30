using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp1
{
    internal class StudentApp
    {
        int rollNumber;
        string name;
        float cgpa;
         
        public StudentApp(int rNum,string nm,float Cgpa) {
            rollNumber = rNum;
            name = nm;
            cgpa = Cgpa;    
        }

        public void displayData() {
            Console.WriteLine("Student details:");
            Console.WriteLine("Roll number:"+rollNumber);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("CGPA:"+cgpa);

        }
    }
}
