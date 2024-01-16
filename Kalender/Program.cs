using System;
using System.ComponentModel.Design;

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
                            }
                            else
                            {
                                Console.WriteLine("Ungültiges Datumsformat. Bitte verwenden Sie das Format JJJJ-MM-TT.");
                            }
                            break;

                        case ConsoleKey.R:
                            foreach (var item in termine)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        case ConsoleKey.A:
                            Console.WriteLine("-");
                            break;

                        case ConsoleKey.D:
                            Console.WriteLine("-");
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