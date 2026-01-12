// Aufgabe 1

//Aufgaben.Aufgabe1();

// Aufgabe 2

//Aufgaben.Aufgabe2();

// Aufgabe 3

//Aufgaben.Aufgabe3();
Aufgaben.Aufgabe31();

public static class Aufgaben
{
    public static void Aufgabe1()
    {
        Console.WriteLine("===== ALTERSKLASSIFIZIERUNG =====\n");

        Console.Write("Bitte gib dein Alter ein: ");

        if (!int.TryParse(Console.ReadLine(), out int alter))
        {
            Console.WriteLine("FEHLER: Ungültige Eingabe!");
            return;
        }

        if (alter < 0 || alter > 120)
        {
            Console.WriteLine("FEHLER: Alter muss zwischen 0 und 120 liegen!");
            return;
        }

        Console.WriteLine();

        string kategorie;
        string info;

        if (alter >= 0 && alter <= 12)
        {
            kategorie = "Kind";
            info = "- Du besuchst noch die Grundschule\n- Schulpflicht\n- Keine Arbeitserlaubnis";
        }
        else if (alter >= 13 && alter <= 19)
        {
            kategorie = "Teenager";
            info = "- Du kannst noch nicht fahren\n- Du kannst arbeiten (mit Einschränkungen)\n- Schulpflicht bis 18";
        }
        else if (alter >= 20 && alter <= 64)
        {
            kategorie = "Erwachsen";
            info = "- Du darfst fahren\n- Du kannst arbeiten\n- Eigene Verantwortung";
        }
        else
        {
            kategorie = "Senior";
            info = "- Du kannst fahren\n- Du kannst arbeiten\n- Rentenberechtigung";
        }

        Console.WriteLine($"Du bist: {kategorie}\n");
        Console.WriteLine("Informationen:");
        Console.WriteLine(info);
    }

    public static void Aufgabe2()
    {
        Console.WriteLine("===== NOTENRECHNER MIT BONUS =====\n");

        Console.Write("Erreichte Punkte (0-100): ");
        if (!int.TryParse(Console.ReadLine(), out int punkte) || punkte < 0 || punkte > 100)
        {
            Console.WriteLine("FEHLER: Ungültige Punkte!");
            return;
        }

        Console.Write("Klassengröße (KlEiN/GROß): ");

        // --> klein bzw. groß
        string klasse = Console.ReadLine().ToLower();


        int bonus = 0;
        string bonusInfo = "";

        if (klasse == "klein")
        {
            bonus = 3;
            bonusInfo = "kleine Klasse";
        }
        else if (klasse == "groß")
        {
            bonus = 0;
            bonusInfo = "große Klasse";
        }
        else
        {
            Console.WriteLine("FEHLER: Ungültige Klassengröße!");
            return;
        }

        int endpunkte = punkte + bonus;

        if (endpunkte > 100)
        {
            endpunkte = 100;
        }

        Console.WriteLine();
        Console.WriteLine($"Rohe Punkte: {punkte}");
        Console.WriteLine($"Klassenbonus: +{bonus}% ({bonusInfo})");
        Console.WriteLine($"Endpunkte: {endpunkte}");
        Console.WriteLine();

        string note;
        string symbol;

        if (endpunkte >= 90 && endpunkte <= 100)
        {
            note = "Sehr Gut (1.0)";
        }
        else if (endpunkte >= 80 && endpunkte < 90)
        {
            note = "Gut (2.0)";
        }
        else if (endpunkte >= 70 && endpunkte < 80)
        {
            note = "Befriedigend (3.0)";
        }
        else if (endpunkte >= 60 && endpunkte < 70)
        {
            note = "Ausreichend (4.0)";
        }
        else if (endpunkte >= 50 && endpunkte < 60)
        {
            note = "Mangelhaft (5.0)";
        }
        else
        {
            note = "Ungenügend (6.0)";
        }


        Console.WriteLine("Bewertung:");
        Console.WriteLine("──────────");
        Console.WriteLine($"{note}");
    }

    public static void Aufgabe3()
    {
        Console.WriteLine("===== WOCHENTAG-FINDER =====\n");

        Console.Write("Gib eine Zahl ein (1-7): ");

        if (!int.TryParse(Console.ReadLine(), out int tag))
        {
            Console.WriteLine("FEHLER: Ungültige Eingabe!");
            return;
        }

        Console.WriteLine();

        switch (tag)
        {
            case 1:
                Console.WriteLine("Wochentag: Montag (Start der Woche)");
                break;
            case 2:
                Console.WriteLine("Wochentag: Dienstag (Noch früh in der Woche)");
                break;
            case 3:
                Console.WriteLine("Wochentag: Mittwoch (Mitte der Woche)");
                break;
            case 4:
                Console.WriteLine("Wochentag: Donnerstag (Später in der Woche)");
                break;
            case 5:
                Console.WriteLine("Wochentag: Freitag (Ende der Woche!)");
                break;
            case 6:
                Console.WriteLine("Wochentag: Samstag (Wochenende!)");
                break;
            case 7:
                Console.WriteLine("Wochentag: Sonntag (Ruhetag)");
                break;
            default:
                Console.WriteLine("FEHLER: Ungültige Eingabe! (Nur 1-7 erlaubt)");
                break;
        }

    }

    public static void Aufgabe31()
    {
        Console.Write("Gib eine Zahl ein (1-7): ");

        if (!int.TryParse(Console.ReadLine(), out int tag))
        {
            Console.WriteLine("FEHLER: Ungültige Eingabe!");
            return;
        }
        string tagText = tag switch
        {
            1 => "Montag (Start der Woche)",
            2 => "Dienstag (Noch früh)",
            3 => "Mittwoch (Mitte)",
            4 => "Donnerstag (Später)",
            5 => "Freitag (Ende!)",
            6 => "Samstag (Wochenende!)",
            7 => "Sonntag (Ruhetag)",
            _ => "FEHLER: Ungültig!"
        };
        Console.WriteLine($"Wochentag: {tagText}");
    }

}