/* 
    Avinash M
    08/16/18
    Bank account details and transactions
*/

using System;
using System.Collections.Generic;

namespace BankAccount.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Application");

            List<Account> accounts = new List<Account>();
            string userInput = "N";

            Console.Write("Do you want to add new account (Y/N): ");
            userInput = Console.ReadLine();
            while (userInput.ToUpper() == "Y")
            {
                Account newAccount = new Account();
                newAccount.GetDetails();
                accounts.Add(newAccount);
                Console.Write("Please enter the withdraw amount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());
                newAccount.Withdraw(withdraw);
                Console.Write("Do you want to add new account (Y/N): ");
                userInput = Console.ReadLine();
            }


            DisplayAccounts(accounts);
        }

        static void DisplayAccounts(List<Account> accounts)
        {
            Console.WriteLine($"\nName\t\t\tAge\tAccountNumber\tBalance");
            foreach (Account a in accounts)
                a.ShowDetails();
        }
    }
}
