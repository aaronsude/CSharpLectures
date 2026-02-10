using System;
using System.Collections.Generic;
using System.Text;

namespace Async
{
    internal class Test
    {
        public static async Task<string> FetchDataAsync(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);  // ← Warten auf Netzwerk
            }
        }

        public static async Task<int> GetNumberAsync()
        {
            await Task.Delay(1000);
            return 42;
        }

        public static int GetNumber()
        {
            return 42;
        }

        public static long CalculateNthPrime(int n)
        {
            int count = 0;
            long currentNumber = 1;

            while (count < n)
            {
                currentNumber++;
                if (IsPrime(currentNumber))
                {
                    count++;
                }
            }
            return currentNumber;
        }

        private static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            // Checking divisors up to the square root of the number
            for (long i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static async Task<string> DownloadAsync(string url)
        {
            Console.WriteLine("1. Starte Download");
            string content = await File.ReadAllTextAsync(url);
            Console.WriteLine("2. Download beendet");
            return content;
        }
    }
}
