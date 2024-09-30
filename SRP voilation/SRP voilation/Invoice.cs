using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_voilation
{
    internal class Invoice
    {
        string _ID, _description;
        double _amount,_tax,_discountPercent;

        public string ID {
            get { return _ID; }
        }

        public string Description { 
            get { return _description; }    
        }

        public double Amount { 
            get { return _amount; }
        }

        public double Tax
        {
            get { return _tax; }
        }

        public double DiscountPercent { 
            get { return _discountPercent; }
        }

        public Invoice(string _ID, string _description, double _amount) { 
            this._ID=_ID;
            this._description=_description;
            this._amount=_amount;
            _tax = 0.1;
            _discountPercent = 0.05;
        }

        public double CalculateTax() {
            _tax= _amount*0.1;
            return _tax; 
        }
        public double CalculateDiscount() { 
              
            return _amount*_discountPercent;
        }
        public double CalculateTotal() { 
            return _amount+CalculateTax()-CalculateDiscount();
        }
        
    }   
}
