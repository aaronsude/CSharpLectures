using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling
{
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException() : base("Amount must be positive!") { }
        public InvalidAmountException(string message) : base(message) { }
    }

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient funds!") { }
        public InsufficientFundsException(string message) : base(message) { }
    }

    public class BankAccount
    {
        public string Name { get; }
        public int AccountNumber { get; }
        private decimal _balance;

        public decimal Balance => _balance;

        public BankAccount(string name, int accountNumber, decimal initialBalance)
        {
            Name = name;
            AccountNumber = accountNumber;
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Amount must be positive!");

            _balance += amount;
            Console.WriteLine($"{amount}€ deposited → Balance: {_balance}€");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Amount must be positive!");

            if (amount > _balance)
                throw new InsufficientFundsException($"Insufficient funds! (Available: {_balance}€)");

            _balance -= amount;
            Console.WriteLine($"{amount}€ withdrawn → Balance: {_balance}€");
        }

        public Result SafeWithdraw(decimal amount)
        {
            if (amount <= 0)
                return new Result(false, "Amount must be positive!");

            if (amount > _balance)
                return new Result(false, $"Insufficient funds! Available: {_balance}€");

            _balance -= amount;
            return new Result(true);
        }

        public void PrintInfo()
        {
            Console.WriteLine("\nFinal Balance Sheet:");
            Console.WriteLine("────────────────────");
            Console.WriteLine($"Account Holder: {Name}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {_balance}€");
        }
    }

    public record Result(bool IsSuccess, string ErrorMessage = "");


    public class BankManagement
    {
        public static void Start()
        {
            Console.WriteLine("===== BANK ACCOUNT MANAGEMENT =====\n");

            BankAccount account = new BankAccount("Anna", 1001, 1000);
            Console.WriteLine("Creating account:");
            Console.WriteLine($"Name: {account.Name}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance}\n");

            Console.WriteLine("Transactions:");
            Console.WriteLine("─────────────");

            //try
            //{
            //    // Standard transactions
            //    account.Deposit(500);
            //    account.Withdraw(200);

            //    // Triggering InvalidAmountException
            //    Console.Write("\nAttempt: Depositing -100€\n");
            //    account.Deposit(-100);
            //}
            //catch (InvalidAmountException ex)
            //{
            //    Console.WriteLine($"InvalidAmountException: {ex.Message}");
            //}

            //try
            //{
            //    // Triggering InsufficientFundsException
            //    Console.Write("\nAttempt: Withdrawing 5000€\n");
            //    account.Withdraw(5000);
            //}
            //catch (InsufficientFundsException ex)
            //{
            //    Console.WriteLine($"InsufficientFundsException: {ex.Message}");
            //}

            //try
            //{
            //    // Triggering ArgumentNullException for a null account check
            //    Console.Write("\nAttempt: Processing null account\n");
            //    BankAccount nullAccount = null;
            //    if (nullAccount == null)
            //        throw new ArgumentNullException(nameof(nullAccount), "Account cannot be null!");
            //}
            //catch (ArgumentNullException ex)
            //{
            //    // Cleans the message to remove the parameter name for cleaner console output
            //    string cleanMessage = ex.Message.Contains("\r") ? ex.Message.Split('\r')[0] : ex.Message;
            //    Console.WriteLine($"{ex.GetType().Name}: {cleanMessage}");
            //}

           


            var result = account.SafeWithdraw(5000);
            if (!result.IsSuccess)
            {
                Console.WriteLine($"Error: {result.ErrorMessage}");
            }

            account.PrintInfo();
        }
    }

}
