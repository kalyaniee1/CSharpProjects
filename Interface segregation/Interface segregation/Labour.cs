using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_segregation
{
    internal class Labour : IWorker
    {
        public void Drink()
        {
            Console.WriteLine("Labour is drinking"); 
            
        }

        public void Eat()
        {
            Console.WriteLine("Labour is eating"); 
            
        }

        public void StartWork()
        {
            Console.WriteLine("Labour started working"); 
            
        }

        public void StopWork()
        {
            Console.WriteLine("Labour stopped working");
            
        }
    }
}
