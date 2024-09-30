using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class TaxCalculator
    {
        ILogger logger;
        int _tax, _amount, _rate;

        public TaxCalculator(ILogger logger) { 
            this.logger = logger;   
        }

        public void CalculateTax(int amount,int rate) {
            _amount = amount;
            _rate = rate;

            try
            {
                _tax = _amount / _rate;
                Console.WriteLine(_tax);
            }
            catch (Exception e) 
            {
                logger.log(e.ToString());
            }
        }
    }
}
