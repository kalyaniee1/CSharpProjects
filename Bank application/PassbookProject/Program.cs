using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookProject
{
    internal class Program
    {
        public static void OperateBank(Account account)
        {
            string input;
            double amount;
            Console.WriteLine("Welcome to the bank applicaion!");
            input = Console.ReadLine();
            while (input != "x")
            {
                Console.WriteLine("Please choose from the following options:\n" + "Select 1 to check balance \n" + "Select 2 to Deposit \n" + "Select 3 to Withdraw \n" + "Select x to exit \n");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter the amount:");
                    amount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(amount);    
                    Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                    
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter the amount:");
                    amount = Convert.ToDouble(Console.ReadLine());
                    account.Withdrow(amount);
                    Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                    
                }
                else if (input == "x")
                { 
                    Console.WriteLine("Do you want to print your passbook?  yes/no");
                    input=Console.ReadLine();
                    if (input == "yes") {
                        Console.WriteLine("Transaction      Time                   Amount");
                        foreach (Tansaction tansactions in account.Tansactions) {
                            Console.WriteLine(tansactions.TransactionType+"         "+ tansactions.TransactionDateTime+"        "+tansactions.Amount);

                        }
                        Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                        break;
                    }
                }
                else Console.WriteLine("Please enter valid input!");
            }
        }
            static void Main(string[] args)
        {
            Account account =  new Account(1235, "Sammrudhi", "Bank of Baroda", 1000);

            OperateBank(account);

            
        }
    }
}
