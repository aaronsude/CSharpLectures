using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{
    class Aufgaben
    {
        public static void Taschenrechner()
        {
            Console.Write("Erste Zahl eingeben: ");
            string eingabe1 = Console.ReadLine();
            int zahl1 = int.Parse(eingabe1);

            Console.Write("Zweite Zahl eingeben: ");
            string eingabe2 = Console.ReadLine();
            int zahl2 = int.Parse(eingabe2);


            Console.WriteLine();


            int summe = zahl1 + zahl2;
            int differenz = zahl1 - zahl2;
            int produkt = zahl1 * zahl2;
            double quotient = (double)zahl1 / (double)zahl2;      
            int rest = zahl1 % zahl2;           

            // Ausgabe mit Formatierung
            Console.WriteLine("ERGEBNISSE:");
            Console.WriteLine("-----------");
            Console.WriteLine($"Addition ({zahl1} + {zahl2}):       {summe}");
            Console.WriteLine($"Subtraktion ({zahl1} - {zahl2}):    {differenz}");
            Console.WriteLine($"Multiplikation ({zahl1} * {zahl2}): {produkt}");
            Console.WriteLine($"Division ({zahl1} / {zahl2}):       {quotient}");
            Console.WriteLine($"Modulo - Rest ({zahl1} % {zahl2}):  {rest}");
        }

        public static void TypeConversion()
        {
            int intWert = 42;
            double doubleWert = intWert;
            Console.WriteLine($"Original int: {intWert}");
            Console.WriteLine($"Zu double konvertiert: {doubleWert:F2}");
            Console.WriteLine();

            // double → int
            double doubleZahl = 3.99;
            int intZahl = (int)doubleZahl;
            Console.WriteLine($"Original double: {doubleZahl}");
            Console.WriteLine($"Zu int gecastet: {intZahl} (Dezimal verloren!)");
            Console.WriteLine();

            // String → int
            string stringZahl1 = "123";
            int parsedInt = int.Parse(stringZahl1);
            Console.WriteLine($"String \"{stringZahl1}\" zu int: {parsedInt}");

            // String → double
            string stringZahl2 = "45,67";
            double parsedDouble = double.Parse(stringZahl2);
            Console.WriteLine($"String \"{stringZahl2}\" zu double: {parsedDouble}");
            Console.WriteLine();

            // String-Länge
            string text = "Programmieren";
            int laenge = text.Length;
            Console.WriteLine($"Länge von \"{text}\": {laenge} Zeichen");
            Console.WriteLine();

            // Sicherheits-Test mit TryParse
            Console.Write("Gib eine Zahl ein: ");
            string eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out int ergebnis))
            {
                Console.WriteLine($"Erfolgreich zu int konvertiert: {ergebnis}");
            }
            else
            {
                Console.WriteLine("FEHLER: Ungültiges Format!");
            }
        }

        public static void DataTypeSizes()
        {
            Console.WriteLine("===== DATENTYP-SPEICHER =====\n");
            Console.WriteLine($"{"Datentyp",-15} {"Größe (Bytes)",-15} {"Bereich"}");
            Console.WriteLine(new string('-', 70));

            // byte
            Console.WriteLine($"{"byte",-15} {sizeof(byte),-15} {byte.MinValue} bis {byte.MaxValue}");

            // int
            Console.WriteLine($"{"int",-15} {sizeof(int),-15} {int.MinValue} bis {int.MaxValue}");

            // long
            Console.WriteLine($"{"long",-15} {sizeof(long),-15} {long.MinValue} bis ...");

            // double
            Console.WriteLine($"{"double",-15} {sizeof(double),-15} ±1,8E+308");

            // bool
            Console.WriteLine($"{"bool",-15} {sizeof(bool),-15} true / false");

            // char
            Console.WriteLine($"{"char",-15} {sizeof(char),-15} Unicode-Zeichen");

            Console.WriteLine(new string('-', 70));
            Console.WriteLine("\nErklärung: Größere Typen können größere Wertebereiche speichern.");
            Console.WriteLine("Aber: Größere Typen verbrauchen mehr Speicher!");
        }
    }

}

