using System.Data;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            // Test Add-Überladungen
            Console.WriteLine($"Test 1: Add(5, 3) = {Add(5, 3)}");
            Console.WriteLine($"Test 2: Add(5.5, 3.2) = {Add(5.5, 3.2):F1}");
            Console.WriteLine($"Test 3: Add(2, 3, 4) = {Add(2, 3, 4)}");
            Console.WriteLine();

            // Test IsEven
            Console.WriteLine($"Test 4: IsEven(4) = {IsEven(4)}");
            Console.WriteLine($"Test 5: IsEven(7) = {IsEven(7)}");
            Console.WriteLine();

            // Test Power
            Console.WriteLine($"Test 6: Power(2, 3) = {Power(2, 3)}");
            Console.WriteLine();

            // Test Average
            Console.WriteLine($"Test 7: Average(10, 20, 30) = {Average(10, 20, 30)}");
            Console.WriteLine($"Test 8: Average(2.5, 3.5, 4.5) = {Average(2.5, 3.5, 4.5):F1}");
            Console.WriteLine();

            // Test Factorial
            Console.WriteLine($"Test 9: Factorial(5) = {Factorial(5)}");





            ////Aufgabe 2
            Console.Write("Gib einen Text ein: ");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("ANALYSE-ERGEBNISSE:");
            Console.WriteLine($"Text: \"{text}\"");
            Console.WriteLine($"Länge: {text.Length} Zeichen");
            Console.WriteLine($"Wort-Anzahl: {CountWords(text)}");
            Console.WriteLine($"Vokal-Anzahl: {CountVowels(text)}");
            Console.WriteLine($"Konsonanten-Anzahl: {CountConsonants(text)}");
            Console.WriteLine($"Umgekehrter Text: {ReverseString(text)}");

            Console.WriteLine();
            Console.WriteLine("STATISTIK:");
            Console.WriteLine($"Großbuchstaben: {CountUpperCase(text)}");
            Console.WriteLine($"Kleinbuchstaben: {CountLowerCase(text)}");
            Console.WriteLine($"Zahlen: {CountNumbers(text)}");
        }

        #region Lecture
        public static void PrintInfo(int age, string city, string name = "Gast")
        {
            Console.WriteLine($"Hallo {name}. Du bist {age} alt und lebst in {city}");
        }

        public static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;

        }

        public static bool TryDivide(int dividend, int divisor, out int result)
        {
            if (divisor == 0)
            {
                result = 0;     // out-Parameter muss gesetzt werden
                return false;   // Division durch 0 nicht möglich
            }

            result = dividend / divisor;
            return true;
        }
        #endregion

        #region Aufgabe 1
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

// Alternativ:
        public static int Add(params int[] nums)
        { 
            int sum = 0; 
            foreach(var  num in nums)
            {
                sum += num; 
            }
            return sum;
        }

        // IsEven - Prüft ob Zahl gerade ist
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Power - Potenzrechnung (base ^ exponent)
        public static int Power(int baseValue, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseValue;
            }
            return result;
        }

        // Überladene Average-Methoden
        public static double Average(int a, int b, int c)
        {
            return (a + b + c) / 3.0;  // 3.0 für Dezimal-Division
        }


        public static double Average(params int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            int sum = Add(nums);

            return sum / nums.Length; 
        }

        public static double Average(double a, double b, double c)
        {
            return (a + b + c) / 3.0;
        }

        // Factorial - Berechnet n! (5! = 5*4*3*2*1 = 120)
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region Aufgabe 2
        public static int CountVowels(string text)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                    count++;
            }
            return count;
        }

        public static int CountConsonants(string text)
        {
            int count = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                    count++;
            }

            count -= CountVowels(text);
            return count;
        }

        public static int CountWords(string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        public static string ReverseString(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }

        public static int CountUpperCase(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsUpper(c))
                    count++;
            }
            return count;
        }

        public static int CountLowerCase(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsLower(c))
                    count++;
            }
            return count;
        }

        public static int CountNumbers(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    count++;
            }
            return count;
        }
        #endregion

        #region Aufgabe 3

        #endregion
    }
}
