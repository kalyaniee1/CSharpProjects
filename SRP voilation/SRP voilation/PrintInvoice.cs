using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRP_voilation
{
    internal class PrintInvoice
    {
        Invoice invoice=new Invoice("SH007", "Woolen Shawl", 2300.00);
        public void printInvoice()
        {
            Console.WriteLine("ID                   Description                 Price");
            Console.WriteLine(invoice.ID + "                " + invoice.Description + "              Rs." + invoice.Amount);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Taxes applied:                                 +  Rs." + invoice.CalculateTax());
            Console.WriteLine("Discount applied:                              -  Rs." + invoice.CalculateDiscount());
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Total bill amount:                                Rs." + invoice.CalculateTotal());
        }
    }
}
