using OOP.Models;

//// Aufgabe 1
//Student s1 = new Student("Anna", 12345, 3.8);
//Console.WriteLine("Student 1 created:");
//Console.WriteLine($"Name: {s1.Name}");
//Console.WriteLine($"Student number: {s1.StudentNumber}");
//Console.WriteLine($"GPA: {s1.GPA}");
//Console.WriteLine();
//Console.WriteLine("=== STUDENT INFO ===");
//s1.PrintInfo();


// Aufgabe 2
// Create account
CheckingAccount account = new CheckingAccount(accountHolder: "Anna", accountNumber: 1001, initialBalance: 1000);
Console.WriteLine("Account 1 created:");
Console.WriteLine($"Account Holder: {account.AccountHolder}");
Console.WriteLine($"Account Number: {account.AccountNumber}");
Console.WriteLine($"Balance: {account.Balance}");
Console.WriteLine();

// Transactions
Console.WriteLine("=== TRANSACTIONS ===");
account.Deposit(500);        // OK
account.Withdraw(200);       // OK
Console.WriteLine();

// Failed transactions
Console.WriteLine("Attempt: Depositing -500");
account.Deposit(-500);       // ERROR
Console.WriteLine("Attempt: Withdrawing 5000");
account.Withdraw(5000);      // ERROR
Console.WriteLine();
