using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Kalender
{
    internal class Program
    {
        static void AnzeigeDatumUndZeit(DateTime dateTime)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Willkommen zum Kalender!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Datum: {0:d}\nZeit: {0:t}", dateTime);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Neues Termin: N");
            Console.WriteLine("Termine abrufen: R");
            Console.WriteLine("Termin löschen: D");
            Console.WriteLine("Termin ändern: A");
            Console.WriteLine("");
        }

        static void addNewEvent(Dictionary<DateTime, string> events)
        {
            Console.WriteLine("Geben Sie den gewünschten Datum ein (im Format JJJJ-MM-TT):");
            string userInputDate = Console.ReadLine();

            if (DateTime.TryParse(userInputDate, out DateTime date))
            {
                Console.WriteLine("Geben Sie den Termin ein:");
                string userInputEvent = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userInputEvent))
                {
                    events[date] = userInputEvent;
                    Console.WriteLine($"Termin am {date.ToShortDateString()} eingetragen: {userInputEvent}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Der Termin darf nicht leer sein. Bitte geben Sie einen gültigen Termin ein.");
                    Console.WriteLine("");
                }

            }
            else
            {
                Console.WriteLine("Ungültiges Datumsformat. Bitte verwenden Sie das Format JJJJ-MM-TT.");
                Console.WriteLine("");
            }
        }

        static void showEvents(Dictionary<DateTime, string> events)
        {
            if (events.Count > 0)
            {
                foreach (var item in events)
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
        }

        static void updateEvent(Dictionary<DateTime, string> events)
        {
            Console.WriteLine("Geben Sie den gewünschten Datum ein, den Sie verändern möchten (im Format JJJJ-MM-TT):");
            string userInputDateEventChange = Console.ReadLine();


            if (DateTime.TryParse(userInputDateEventChange, out DateTime dateEventChange) && events.ContainsKey(dateEventChange))
            {
                Console.WriteLine($"Aktueller Termin für {dateEventChange.ToShortDateString()}: {events[dateEventChange]}");
                Console.WriteLine("Geben Sie den neuen Termin ein:");
                string updatedEvent = Console.ReadLine();

                events[dateEventChange] = updatedEvent;
                Console.WriteLine($"Termin am {dateEventChange.ToShortDateString()} aktualisiert: {updatedEvent}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Ungültiges Datum oder kein Termin für das angegebene Datum gefunden.");
                Console.WriteLine("");
            }
        }

        static void deleteEvent(Dictionary<DateTime, string> events)
        {
            Console.WriteLine("Geben Sie den gewünschten Datum ein, den Sie löschen möchten (im Format JJJJ-MM-TT):");
            string userInputDateEventDelete = Console.ReadLine();

            if (DateTime.TryParse(userInputDateEventDelete, out DateTime dateEventDelete) && events.ContainsKey(dateEventDelete))
            {
                Console.WriteLine($"Aktueller Termin für {dateEventDelete.ToShortDateString()}: {events[dateEventDelete]}");
                Console.WriteLine("Sind Sie sicher, dass Sie diesen Termin löschen möchten ('Y' = Ja, 'N' = Nein)?");

                ConsoleKeyInfo userInputDeletion = Console.ReadKey(true);

                switch (userInputDeletion.Key)
                {
                    case ConsoleKey.Y:
                        events.Remove(dateEventDelete);
                        Console.WriteLine($"Termin am {dateEventDelete} erfolgreich gelöscht.");
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
        }

        static void Main(string[] args)
        {
            DateTime currentDateAndTime = DateTime.Now;

            Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

            AnzeigeDatumUndZeit(currentDateAndTime);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userKeyInput = Console.ReadKey(true);

                    switch (userKeyInput.Key)
                    {
                        case ConsoleKey.N:
                            addNewEvent(events);
                            break;

                        case ConsoleKey.R:
                            showEvents(events);
                            break;

                        case ConsoleKey.A:
                            updateEvent(events);
                            break;

                        case ConsoleKey.D:
                            deleteEvent(events);
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