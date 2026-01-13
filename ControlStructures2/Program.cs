//Aufgaben.Aufgabe1();
//Aufgaben.Aufgabe2();
Aufgaben.Aufgabe3();




public class Aufgaben
{
//Größe der Tabelle eingeben(1-10): 5
    
//   1   2   3   4   5
//1  1   2   3   4   5
//2  2   4   6   8  10
//3  3   6   9  12  15
//4  4   8  12  16  20
//5  5  10  15  20  25
    public static void Aufgabe1()
    {
        Console.Write("Größe der Tabelle eingeben (1-10): ");
        if (!int.TryParse(Console.ReadLine(), out int groesse) || groesse < 1 || groesse > 10)
        {
            Console.WriteLine("FEHLER: Ungültige Eingabe!");
            return;
        }

        Console.WriteLine();

        // Header-Zeile ausgeben
        Console.Write("   ");  // Platz für Reihen-Nummer
        for (int i = 1; i <= groesse; i++)
        {
            Console.Write($"{i,3}");
        }
        Console.WriteLine();

        // Trennlinie
        for (int i = 0; i < groesse * 3 + 3; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();

        for (int i = 1; i <= groesse; i++)  // Reihen (äußere Schleife)
        {
            Console.Write($"{i}  ");  // Reihen-Nummer

            for (int j = 1; j <= groesse; j++)  // Spalten (innere Schleife)
            {
                int produkt = i * j;
                Console.Write($"{produkt,3}");  // Formatierung: 3 Zeichen breit
            }

            Console.WriteLine();  // Neue Zeile nach innerer Schleife
        }
    }

    //    OPTION 1: Dreieck
    //1
    //2 2
    //3 3 3
    //4 4 4 4
    //5 5 5 5 5

    //OPTION 2: Pyramide(zentriert)
    //    1
    //   2 2
    //  3 3 3
    // 4 4 4 4
    //5 5 5 5 5

    //OPTION 3: Aufsteigend
    //1 2 3 4 5
    //1 2 3 4
    //1 2 3
    //1 2
    //1

    public static void Aufgabe2()
    {
        Console.Write("Höhe eingeben (1-10): ");
        if (!int.TryParse(Console.ReadLine(), out int hoehe) || hoehe < 1 || hoehe > 10)
        {
            Console.WriteLine("FEHLER: Ungültige Eingabe!");
            return;
        }

        Console.WriteLine();

        Console.WriteLine("OPTION 1: Dreieck");
        for (int i = 1; i <= hoehe; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("OPTION 2: Pyramide (zentriert)");
        for (int i = 1; i <= hoehe; i++)
        {
            for (int leerzeichen = 0; leerzeichen < hoehe - i; leerzeichen++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("OPTION 3: Aufsteigend");
        for (int i = hoehe; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Aufgabe3()
    {

        const int MAX_VERSUCHE = 10;
        Console.WriteLine("===== ZAHLENRÄTSEL =====\n");
        Console.WriteLine("Ich denke mir eine Zahl zwischen 1 und 100.");
        Console.WriteLine($"Du hast maximal {MAX_VERSUCHE} Versuche!\n");

        Random random = new Random();
        int geheimZahl = random.Next(1, 101);

        int versuch = 0;
        bool richtig = false;

        while (versuch < MAX_VERSUCHE && !richtig)
        {
            //Wichtig um endlos schleife zu verhindern
            versuch++;

            Console.Write($"Versuch {versuch}/{MAX_VERSUCHE}: Gib eine Zahl ein: ");

            if (!int.TryParse(Console.ReadLine(), out int geraten))
            {
                Console.WriteLine("FEHLER: Ungültige Eingabe!");
                continue;
            } 
            if (geraten == geheimZahl)
            {
                richtig = true;
                Console.WriteLine($"Richtig!");
                Console.WriteLine($"Du hast es in {versuch} Versuchen geschafft!");
            }
            else if (geraten < geheimZahl)
            {
                Console.WriteLine("Zu niedrig! Versuche es größer.\n");
            }
            else
            {
                Console.WriteLine("Zu hoch! Versuche es kleiner.\n");
            }
        }

        if (!richtig)
        {
            Console.WriteLine($"Game Over! Die Zahl war {geheimZahl}.");
            Console.WriteLine("Du hast leider alle Versuche aufgebraucht!");
        }
    }
}