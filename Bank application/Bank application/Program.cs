using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application
{
    internal class Program
    {
        public static void OperateBank(Account account) {
            string input;
            double amount;
            Console.WriteLine("Welcome to the bank applicaion!");
            input = Console.ReadLine();
            while (input!="x") {
                Console.WriteLine("Please choose from the following options:\n" + "Select 1 to check balance \n" + "Select 2 to Deposit \n"+ "Select 3 to Withdraw \n" + "Select x to exit \n");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter the amount:");
                    amount = Convert.ToDouble(Console.ReadLine());
                    if (account.Deposit(amount))
                        Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                    else
                        Console.WriteLine("Maximum deposit amount must be Rs. 50000");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter the amount:");
                    amount = Convert.ToDouble(Console.ReadLine());
                    if (account.Withdrow(amount))
                        Console.WriteLine("Current balance: Rs." + account.CheckBalance());
                    else
                        Console.WriteLine("Transaction fialed! Minimum balance of Rs. 500 must be");
                }
                else if (input == "x")
                { }
                else Console.WriteLine("Please enter valid input!");
            }

           
        }

        public static void PrintMaxBalanceAccountDetails(Account account)
        {
            Console.WriteLine("Details of account with highest balance:");
            Console.WriteLine("Account number:" + account.AccountNumber);
            Console.WriteLine("Account holder:" + account.AccountHolder);
            Console.WriteLine("Bank name:" + account.BankName);
            Console.WriteLine("Account balance:" + account.Balance);

        }

        static void Main(string[] args)
        {
            Account[] account = { new Account(1234, "Kalyaniee R", "Bank of Baroda"), new Account(1235, "Sammrudhi", "Bank of Baroda", 700) };
            
            bool operateAccount=true;
            while (operateAccount==true) {
                Console.WriteLine("Enter the account number to be operated:");
                int accountNo = Convert.ToInt16(Console.ReadLine());

                for (int i = 0; i < account.Length; i++)
                {
                    if (account[i].AccountNumber == accountNo)
                    {
                        OperateBank(account[i]);
                        break;
                    }
                    
                }
                Console.WriteLine("Do you want to operate any ther account? Y/N");

                if (Console.ReadLine() == "N")
                    operateAccount = false;
                else if (Console.ReadLine() == "Y")
                    operateAccount = true;

            }


            PrintMaxBalanceAccountDetails(Account.FindMaxBalanceAccount(account));

            SerializerClass serializerClass = new SerializerClass();
            

            for (int i=0;i<account.Length;i++)
                serializerClass.Serializer(account[i]);
            //Account[] deserialisedAccounts=new Account[100];

            Account[] deserialisedAccounts = new Account[10];
            //for (int i = 0; i < account.Length; i++)
                deserialisedAccounts= serializerClass.DeSerializer();
            if (deserialisedAccounts != null)
            {
                int i = 0;
                while (deserialisedAccounts[i]!=null)
                {
                    Console.WriteLine("Acoount number:" + deserialisedAccounts[i].AccountNumber);
                    Console.WriteLine("Acoount holder:" + deserialisedAccounts[i].AccountHolder);
                    Console.WriteLine("Bank name:" + deserialisedAccounts[i].BankName);
                    Console.WriteLine("Balance:" + deserialisedAccounts[i].Balance);
                    i++;
                }
            }
            else
                Console.WriteLine("Object is null");
        }
    }
}
