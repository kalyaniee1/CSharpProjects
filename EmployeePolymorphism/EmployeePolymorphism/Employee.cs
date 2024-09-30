using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{

    internal class Employee
    {
        protected int id;
        protected string name;
        protected double basicSalary;

        protected double CTC;

      
        public virtual void CalculateCTC()
        { }


       /* public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double BasicSalary
        {
            set { basicSalary = value; }
            get { return basicSalary; }

        }
        public double CTCs
        {
            set {CTC = value; }
            get { return CTC; }

        }*/

        public void displayData() {
            Console.WriteLine("Employee ID:"+id);
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Basic Salary:"+basicSalary);
        }
    }

    internal class Manager : Employee
    {
        private int level;
        public Manager(int id, string name, double basicSalary) 
        {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            level = 1;
            //Console.WriteLine("Inside manager constrcutor");
        }

       
        public override void CalculateCTC()
        {
            CTC = (basicSalary * 12) +(basicSalary * (13 / 100)) + (basicSalary * (7.5 / 100));
            
        }

        //public new void displayData()
        //{
        //    base.displayData();
        //    Console.WriteLine("Manager Level:" + level);
        //}
    }


    internal class Developer : Employee
    {
        private string technology;
        public Developer(int id, string name, double basicSalary) 
        {
            this.id= id;
            this.name = name;
            this.basicSalary = basicSalary;
            technology = ".Net";
        }

        public override void CalculateCTC()
        {
            CTC = (basicSalary * 12) + (basicSalary * (13.5 / 100)) + (basicSalary * (8 / 100));
            
        }
        public new void displayData()
        {
            base.displayData();
            Console.WriteLine("Deeveloper technology:" + technology);
        }
    }

    internal class Tester : Employee
    {
        string tool;
        public Tester(int id, string name, double basicSalary) 
        {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            tool = "Selenium";
        }
        public override void CalculateCTC()
        {
            CTC = (basicSalary * 12) + (basicSalary * (14 / 100)) + (basicSalary * (8.5 / 100));
           
        }
        public new void displayData()
        {
            base.displayData();
            Console.WriteLine("Testing tool:" + tool);
        }
    }
}

   