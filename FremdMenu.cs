namespace KurzNotizApp;

public class FremdMenu
{
    // Das ist ein Code, denn ich von einer Website kopiert habe, auf der Suche nach einem
    // Konsolen-Menü.
    // https://entwickler-ecke.de/topic_C+Console+Menue+erstellen_101851,0.html
    
    public static void FremdMenuStart()
    {
        bool done = false;
        do
        {
            // In jedem Durchlauf werden diese 4 Variablen erneut generiert.
            // Für mich ist noch nicht klar, ob das eine gute Lösung ist.
            // Es fühlt sich nicht richtig an.
            structTeilnehmer Name_eingeben = new structTeilnehmer (1);
            structTeilnehmer Vorname_eingeben = new structTeilnehmer (2);
            structTeilnehmer Addresse_eingeben = new structTeilnehmer (3);
            structTeilnehmer Liste_anzeigen = new structTeilnehmer (4);
            Console.WriteLine("Select one of the following:");
            Console.WriteLine("\t1 -- Name eingeben");
            Console.WriteLine("\t2 -- Vorname eingeben");
            Console.WriteLine("\t3 -- Addresse eingeben");
            Console.WriteLine("\t4 -- Liste anzeigen");
            Console.Write ("Gib deine Auswahl ein (0 zum Abbrechen): ");
            string strSelection = Console.ReadLine ();
            int iSel;
            try
            {
                iSel = int.Parse(strSelection);
            }
            catch (FormatException)
            {
                Console.WriteLine ("\r\nWas?\r\n");
                continue;
            }
            Console.WriteLine ("Du hast ausgesucht  " + iSel);
            switch (iSel)
            {
                case 0:
                    done = true;
                    break;
                case 1:
                    Console.WriteLine (Name_eingeben);
                    break;
                case 2:
                    Console.WriteLine (Vorname_eingeben);
                    break;
                case 3:
                    Console.WriteLine (Addresse_eingeben);
                    break;
                case 4:
                    Console.WriteLine (Liste_anzeigen);
                    break;
                default:
                    Console.WriteLine ("Du hast eine Falsche Nummer gewählt: {0}\r\n", iSel);
                    continue;
            }
            Console.WriteLine ();
        } while (!done);

        Console.WriteLine ("\nGoodbye!");
    }
}
    
struct structTeilnehmer
{
    private int Type;
    public structTeilnehmer (int Type)
    {
        // Der Originalcode hatte hier einen, glaube ich, Fehler.
        // Original stand hier: structTeilnehmer = Type;
        // Zum einen löst das einen Fehler in Rider aus, zum anderen macht es auch keinen Sinn.
        // Der Struktur über den Konstruktor etwas zuzuweisen kann nicht funktionieren.
        this.Type = Type;
    }
    public int TeilnehmerType
    {
        get {return (Type);}
        set {Type = value;}
    }
    public override string ToString()
    {
        switch (Type)
        {
            default:
                return ("Unbekannte_Eingabe");
            case 1:
                return ("Name_eingeben");
            case 2:
                return ("Vorname_einegebn");
            case 3:
                return ("Addresse_eingeben");
            case 4:
                return ("Liste_anzeigen");
        }
    }
}