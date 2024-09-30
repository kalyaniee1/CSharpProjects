using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregation
{
    internal class Robot : IWorkable
    {
        
        public void StartWork()
        {
            Console.WriteLine("Robo started working"); 
            
        }

        public void StopWork()
        {
            Console.WriteLine("Robo stopped working");
            
        }
    }
}
