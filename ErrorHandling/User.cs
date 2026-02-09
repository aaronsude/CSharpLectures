using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ErrorHandling
{
    internal class User
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Management
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("===== USER REGISTRATION =====");
            User newUser = new User();

            while (true)
            {
                Console.Write("Enter name: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Name is required.");
                }
                else
                {
                    newUser.Name = input.Trim();
                    break;
                }
            }

            while (true)
            {
                Console.Write("Enter age: ");
                string? input = Console.ReadLine();

                // Validate integer parsing (no try-catch)
                if (!int.TryParse(input, out int parsedAge))
                {
                    Console.WriteLine("Error: Age must be a whole number!");
                }
                else
                {
                    // Validate business rules
                    if (parsedAge < 0)
                    {
                        Console.WriteLine("Error: Age must be positive.");
                    }
                    else if (parsedAge > 150)
                    {
                        Console.WriteLine("Error: Age is too high.");
                    }
                    else
                    {
                        newUser.Age = parsedAge;
                        break;
                    }
                }
            }

            while (true)
            {
                Console.Write("Enter email: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Email is required.");
                }
                else
                {
                    newUser.Email = input.Trim();
                    break;
                }
            }

            Console.WriteLine("Registration successful!");
            Console.WriteLine();

            newUser.PrintInfo();

            Console.ReadLine();
        }
    }
}
