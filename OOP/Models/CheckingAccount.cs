using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    internal class CheckingAccount
    {
        // Properties
        public string AccountHolder { get; set; }
        public int AccountNumber { get; private set; }  // Read-only after creation

        // Private balance with validation
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }  // Only settable internally
        }

        // Constructor with initial value
        public CheckingAccount(string accountHolder, int accountNumber, decimal initialBalance = 0)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Amount must be positive!");
                return false;
            }

            Balance += amount;
            Console.WriteLine($"{AccountHolder}: {amount} deposited. New balance: {Balance}");
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Error: Amount must be positive!");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine($"Error: Insufficient funds! (Available: {Balance})");
                return false;
            }

            Balance -= amount;
            Console.WriteLine($"{AccountHolder}: {amount} withdrawn. New balance: {Balance}");
            return true;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Account Info:");
            Console.WriteLine("──────────");
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
