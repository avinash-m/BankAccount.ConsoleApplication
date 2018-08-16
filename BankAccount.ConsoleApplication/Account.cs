using System;

namespace BankAccount.ConsoleApplication
{
    class Account
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string AccountNumber { get; set; }
        public int Balance { get; set; }

        public void GetDetails()
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

        public void Withdraw(double withdrawAmount)
        {
            if (withdrawAmount <= Amount)
                Balance -= withdrawAmount;
            else
                Console.WriteLine("Withdraw amount is more than the available balance.");
        }

    }
}
