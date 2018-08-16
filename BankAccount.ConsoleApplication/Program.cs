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
            }


            
        }
    }
}
