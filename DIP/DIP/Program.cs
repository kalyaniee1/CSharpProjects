﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator = new TaxCalculator(new FileLogger());
            taxCalculator.CalculateTax(10000,0);

        }
    }
}
