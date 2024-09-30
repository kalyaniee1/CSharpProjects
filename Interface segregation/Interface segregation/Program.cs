using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorkable robo=new Robot();
            robo.StartWork();
           
            robo.StartWork();
            robo.StopWork();

            IWorker labour=new Labour();
            labour.StartWork(); 
            labour.Drink();
            labour.Eat();
            labour.StartWork();
            labour.StopWork();
        }
    }
}
