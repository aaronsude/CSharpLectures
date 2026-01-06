namespace CSharpLectures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            Aufgabe3();
        }

        static void Aufgabe1()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Willkommen zu C# Programmierung");
            Console.WriteLine("=====================================");
            Console.WriteLine("Hallo! Das ist dein erstes Programm!");

        }

        static void Aufgabe2()
        {
            string name = "Aaron";
            int alter = 27;
            string stadt = "Kassel";
            Console.WriteLine($"{name} ist {alter} Jahre alt und kommt aus {stadt}.");

        }

        static void Aufgabe3()
        {
            //Hallo Aaron! Schön dich kennenzulernen!
            //Dein Name hat 5 Buchstaben.
            Console.Write("Bitte Name eingeben:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hallo {name}! Schön dich kennenzulernen!");
            Console.WriteLine($"Dein Name hat {name.Length} Buchstaben");
        }
    }


}
