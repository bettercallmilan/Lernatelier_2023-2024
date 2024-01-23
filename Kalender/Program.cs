using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Kalender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;

            Dictionary<DateTime, string> termine = new Dictionary<DateTime, string>();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Willkommen zum Kalender!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Datum: {0:d}\n" +
                "Zeit: {0:t}", d);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Neues Termin: N");
            Console.WriteLine("Termine abrufen: R");
            Console.WriteLine("Termin löschen: D");
            Console.WriteLine("Termin ändern: A");
            Console.WriteLine("");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo taste = Console.ReadKey(true);

                    switch (taste.Key)
                    {
                        case ConsoleKey.N:
                            Console.WriteLine("Geben Sie den gewünschten Datum ein (im Format JJJJ-MM-TT):");
                            string datum = Console.ReadLine();

                            if (DateTime.TryParse(datum, out DateTime date))
                            {
                                Console.WriteLine("Geben Sie den Termin ein:");
                                string termin = Console.ReadLine();

                                termine[date] = termin;
                                Console.WriteLine($"Termin am {date.ToShortDateString()} eingetragen: {termin}");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Ungültiges Datumsformat. Bitte verwenden Sie das Format JJJJ-MM-TT.");
                                Console.WriteLine("");
                            }
                            break;

                        case ConsoleKey.R:
                            if (termine.Count > 0)
                            {
                                foreach (var item in termine)
                                {
                                    Console.WriteLine(item);
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Keine Termine gefunden.");
                                Console.WriteLine("");
                            }
                            break;

                        case ConsoleKey.A:
                            Console.WriteLine("Geben Sie den gewünschten Datum ein, den Sie verändern möchten (im Format JJJJ-MM-TT):");
                            string datumAendern = Console.ReadLine();

                            if (DateTime.TryParse(datumAendern, out DateTime datumAendern1) && termine.ContainsKey(datumAendern1))
                            {
                                Console.WriteLine($"Aktueller Termin für {datumAendern1.ToShortDateString()}: {termine[datumAendern1]}");
                                Console.WriteLine("Geben Sie den neuen Termin ein:");
                                string neuerTermin = Console.ReadLine();

                                termine[datumAendern1] = neuerTermin;
                                Console.WriteLine($"Termin am {datumAendern1.ToShortDateString()} aktualisiert: {neuerTermin}");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Ungültiges Datum oder kein Termin für das angegebene Datum gefunden.");
                                Console.WriteLine("");
                            }
                            break;

                        case ConsoleKey.D:
                            Console.WriteLine("Geben Sie den gewünschten Datum ein, den Sie löschen möchten (im Format JJJJ-MM-TT):");
                            string datumLoeschen = Console.ReadLine();

                            if (DateTime.TryParse(datumLoeschen, out DateTime datumLoeschen1) && termine.ContainsKey(datumLoeschen1))
                            {
                                Console.WriteLine($"Aktueller Termin für {datumLoeschen1.ToShortDateString()}: {termine[datumLoeschen1]}");
                                Console.WriteLine("Sind Sie sicher, dass Sie diesen Termin löschen möchten ('Y' = Ja, 'N' = Nein)?");

                                ConsoleKeyInfo taste1 = Console.ReadKey(true);

                                switch (taste1.Key)
                                {
                                    case ConsoleKey.Y:
                                        termine.Remove(datumLoeschen1);
                                        Console.WriteLine($"Termin am {datumLoeschen1} erfolgreich gelöscht.");
                                        Console.WriteLine("");
                                        break;

                                    case ConsoleKey.N:
                                        Console.WriteLine("Terminlöschung abgebrochen.");
                                        Console.WriteLine("");
                                        break;

                                    default:
                                        Console.WriteLine("Ungültige Taste. Drücken Sie 'Y' (Termin löschen) oder 'N' (Termin beibehalten).");
                                        Console.WriteLine("");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ungültiges Datum oder kein Termin für das angegebene Datum gefunden.");
                                Console.WriteLine("");

                            }
                            break;

                        default:
                            Console.WriteLine("Ungültige Taste. Drücken Sie 'N' (neues Termin), 'R' (Termine abrufen), 'D' (Termin löschen) oder 'A' (Termin verändern).");

                            break;

                    }
                }
            }
        }
    }
}