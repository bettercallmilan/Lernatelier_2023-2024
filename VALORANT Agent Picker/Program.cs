using System.Globalization;

namespace VALORANT_Agent_Picker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char antwort;
            string[] duelist = {"Raze", "Jett", "Phoenix", "Reyna", "Yoru", "Neon"};
            string[] sentinel = {"Killjoy", "Cypher", "Sage", "Chamber", "Deadlock"};
            string[] initiator = {"Breach", "Gekko", "KAY/O", "Skye", "Sova", "Fade"};
            string[] controller = {"Astra", "Brimstone", "Omen", "Viper", "Harbor"};

            Console.WriteLine("VALORANT_Agent_Picker v0.0.1");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Beschreibung: d = duelist / s = sentinel / i = initiator / c = controller");
            Console.WriteLine("");

            try
            {
                while (true)
                {
                    Console.Write("Welche Klasse von Agenten möchten Sie spielen [d/s/i/c]? ");
                    antwort = Convert.ToChar(Console.ReadLine());
                    switch (antwort)
                    {
                        case 'd':
                            Random random = new Random();
                            int zufälligerIndex = random.Next(0, duelist.Length);
                            string ausgabe = duelist[zufälligerIndex];
                            Console.WriteLine($"Sie werden diesmal {ausgabe} spielen.");
                            Console.WriteLine("");
                            break;
                        case 's':
                            Random random1 = new Random();
                            int zufälligerIndex1 = random1.Next(0, sentinel.Length);
                            string ausgabe1 = sentinel[zufälligerIndex1];
                            Console.WriteLine($"Sie werden diesmal {ausgabe1} spielen.");
                            Console.WriteLine("");
                            break;
                        case 'i':
                            Random random2 = new Random();
                            int zufälligerIndex2 = random2.Next(0, initiator.Length);
                            string ausgabe2 = initiator[zufälligerIndex2];
                            Console.WriteLine($"Sie werden diesmal {ausgabe2} spielen.");
                            Console.WriteLine("");
                            break;
                        case 'c':
                            Random random3 = new Random();
                            int zufälligerIndex3 = random3.Next(0, controller.Length);
                            string ausgabe3 = controller[zufälligerIndex3];
                            Console.WriteLine($"Sie werden diesmal {ausgabe3} spielen.");
                            Console.WriteLine("");
                            break;
                    }
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Ein Fehler ist aufgetreten.");
                Console.WriteLine("Stellen Sie sicher, dass Sie die Klasse der Agenten korrekt ausgewählt haben [d/s/i/c].");
            }
        }
    }
}