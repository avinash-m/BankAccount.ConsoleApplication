﻿using System;

namespace BankAccount.ConsoleApplication
{
    class Account
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public void GetDetails()
        {
            try
            {
                Console.Write("Enter name: ");
                Name = Console.ReadLine();
                Console.Write("Enter age: ");
                Age = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter account number: ");
                AccountNumber = Console.ReadLine();
                Console.Write("Enter amount to deposit: ");
                Balance = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input: {e.Message}");
            }
        }

        public void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount <= Balance)
                Balance -= withdrawAmount;
            else
                Console.WriteLine("Withdraw amount is more than the available balance.");

            Console.WriteLine($"Balance: {Balance}");
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{Name, -20}\t{Age, 3}\t{AccountNumber, 5}\t\t{Balance, 7}");
        }

    }
}
