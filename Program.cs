string[] liste = { "Titel:", "Beschreibung:", "Fälligkeitsdatum:", "Priorität:" };

string wahl;

do
{

    Console.WriteLine("Hauptmenü:1 = Aufgabe erfassen, 2 = Aufgaben anzeigen, 3 = Aufgabe löschen, 4 = beenden");
    wahl = Console.ReadLine();

    if (wahl == "1")
    {
        Console.WriteLine("Du hast Aufgabe erfassen gewählt.");
        string[] aufgabe = new string[liste.Length];

        for (int i = 0; i < liste.Length; i++)
        {
            Console.WriteLine(liste[i]);
            string eingabe = Console.ReadLine();

            
            bool richtig = false;

            if (i == 2) 
            {
                while (richtig == false)
                {
                    richtig = DateTime.TryParse(eingabe, out DateTime datum);

                    if (richtig == false)
                    {
                        Console.WriteLine("Kein Datum, nochmal:");
                        eingabe = Console.ReadLine();
                    }
                }
            }
            else if (i == 3) 
            {
                int prio = 0;

                while (richtig == false)
                {
                    richtig = int.TryParse(eingabe, out prio);

                    if (prio < 1)
                    {
                        richtig = false;
                    }

                    if (prio > 3)
                    {
                        richtig = false;
                    }

                    if (richtig == false)
                    {
                        Console.WriteLine("1 bis 3, nochmal:");
                        eingabe = Console.ReadLine();
                    }
                }

                eingabe = prio.ToString();
            }


            aufgabe[i] = eingabe;
        }

        Console.WriteLine("Aufgabe wurde gespeichert.");
    }
    else if (wahl == "2")
    {
        Console.WriteLine("Du hast Aufgaben anzeigen gewählt.");
    }
    else if (wahl == "3")
    {
        Console.WriteLine("Du hast Aufgabe löschen gewählt.");
    }
    else if (wahl == "4")




    {
        Console.WriteLine("Programm wird beendet.");
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe");
    }

} while (wahl != "4");