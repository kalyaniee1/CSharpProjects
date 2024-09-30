using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_voilation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInvoice printInvoice = new PrintInvoice();
            printInvoice.printInvoice();
        }
    }
}
