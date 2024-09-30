using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookProject
{
    internal class Tansaction
    {
        string _transactionType;
        DateTime _transactionDateTime;
        double _amount;

        public Tansaction(string _transactionType,DateTime _transactionDateTime,double _amount) {
            this._transactionType = _transactionType;
            this._transactionDateTime = _transactionDateTime;   
            this._amount = _amount;
        }

        public string TransactionType
        {
            get{ return _transactionType; }
            set { _transactionType = value; }
        }

        public DateTime TransactionDateTime { 
            get { return _transactionDateTime; }
            set { _transactionDateTime = value; } 
        }

        public double Amount { 
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
