# to do liste



   else if (wahl == "6")
    {
        var aufgaben = LadeAufgaben(sheet);
        IEnumerable<Aufgabe> ergebnis = aufgaben;

        Console.WriteLine("Filter: 1 = alle, 2 = nur offene, 3 = nur erledigte, 4 = Priorität");
        string filter = Console.ReadLine();

        if (filter == "2") ergebnis = ergebnis.Where(a => a.Erledigt == "nein");
        else if (filter == "3") ergebnis = ergebnis.Where(a => a.Erledigt == "ja");
        else if (filter == "4")
        {
            Console.WriteLine("Priorität (1-3):");
            int p = int.Parse(Console.ReadLine());
            ergebnis = ergebnis.Where(a => a.Prio == p);
        }

        Console.WriteLine("Sortieren: 1 = Datum, 2 = Priorität, 3 = Titel");
        string sort = Console.ReadLine();

        ergebnis = sort switch
        {
            "1" => ergebnis.OrderBy(a => a.Datum),
            "2" => ergebnis.OrderBy(a => a.Prio),
            "3" => ergebnis.OrderBy(a => a.Titel),
            _ => ergebnis
        };

        foreach (var a in ergebnis)
            Console.WriteLine($"{a.Nr}: {a.Titel} | {a.Beschreibung} | {a.Datum:dd.MM.yyyy} | Prio {a.Prio} | erledigt: {a.Erledigt}");
    }
    else
    {
        Console.WriteLine("Ungültige Eingabe");
    }
