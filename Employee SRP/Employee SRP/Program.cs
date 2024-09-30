using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_SRP
{
    internal class Program
    {
        public Program() {
            
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee("KALMUM010", "Kalynaiee R", "Mumbai", Convert.ToDateTime("2024/04/15"), 100000);
            Accounts accounts = new Accounts();
            HumanResourceDepartment humanResourceDepartment = new HumanResourceDepartment();
            if (humanResourceDepartment.PromotionDue(employee)) 
            {
                Console.WriteLine("Congratulations!! Your promotion is due.");
            }
            else {
                Console.WriteLine("Promotion not due!");
            }
            Console.WriteLine("You are laible to "+accounts.CheckIncomeTaxRate(employee)+" percent of ncome tax on your current salary of Rs."+employee.Salary);
            Console.WriteLine("Therefore you are laible to pay Rs."+accounts.CalculateAnnualIncomeTax(employee)+" to the Govrnment of India as income tax.");
        }
    }
}
