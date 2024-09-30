﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace PassbookProject
{
    
    internal class Account
    {
        int _accountNumber;
        String _accountHolder,_bankName;
        double _balance;
        List<Tansaction> tansactions=new List<Tansaction>();

        public string AccountHolder {

            get { return _accountHolder; }
        }

        public int AccountNumber
        {

            get { return _accountNumber; }
        }

        public string BankName
        {

            get { return _bankName; }
        }

        public double Balance
        {

            get { return _balance; }
        }

        public List<Tansaction> Tansactions {

            get { return tansactions; }
        }
        public Account(int _accountNumber,string _accountHolder,string _bankName,double _balance) { 
        this._accountNumber = _accountNumber;
            this._accountHolder = _accountHolder;   
            this._bankName = _bankName;
            if (_balance >= 500)
                this._balance = _balance;
            else Console.WriteLine("The minimum balance expected is Rs. 500");   
        }

        

        public List<Tansaction> Deposit(double amount) {
            if (amount < 50000)
            {
                _balance = _balance + amount;
                tansactions.Add(new Tansaction("Credit",DateTime.Now,amount));
                
            }
            return tansactions;
            
        }

        public bool Withdrow(double amount)
        {
            if (_balance - amount>500)
            {
                _balance = _balance - amount;
                tansactions.Add(new Tansaction("Debit", DateTime.Now, amount));
                return true;
            }
            return false;

            
        }

        public double CheckBalance() {
            return _balance;
        }

        public static Account FindMaxBalanceAccount(Account[] accounts) {
            Account maxBalanceAccount = accounts[0];
            
            for (int i=0;i<accounts.Length-1;i++) {
                if (accounts[i]._balance > accounts[i + 1]._balance)
                    maxBalanceAccount = accounts[i];
                else
                    maxBalanceAccount = accounts[i + 1];   
            }
            return maxBalanceAccount;
            
        }

        
    }
}
