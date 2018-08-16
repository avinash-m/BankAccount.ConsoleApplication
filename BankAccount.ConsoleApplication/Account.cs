using System;

namespace BankAccount.ConsoleApplication
{
    class Account
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string AccountNumber { get; set; }
        public int Amount { get; set; }

        public void GetDetails()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter account number: ");
            AccountNumber = Console.ReadLine();            
        }
                

        
    }
}
