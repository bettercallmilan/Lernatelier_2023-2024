using System.ComponentModel.Design;

namespace Taschenrechner1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double zahl1;
                    double zahl2;
                    char operation;
                    double ergebnis = 0;

                    Console.Write("Gib die 1. Zahl ein: ");
                    zahl1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Gib die 2. Zahl ein: ");
                    zahl2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Gib die Operation ein (+/-/*/÷): ");
                    operation = Convert.ToChar(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            ergebnis = zahl1 + zahl2;
                            break;
                        case '-':
                            ergebnis = zahl1 - zahl2;
                            break;
                        case '*':
                            ergebnis = zahl1 * zahl2;
                            break;
                        case '÷':
                            if (zahl2 != 0)
                            {
                                ergebnis = zahl1 / zahl2;
                            } else
                            {
                                Console.WriteLine("Man kann durch 0 nicht teilen.");
                            }
                            break;
                        case '/':
                            if (zahl2 != 0)
                            {
                                ergebnis = zahl1 / zahl2;
                            }
                            else
                            {
                                Console.WriteLine("Man kann durch 0 nicht teilen.");
                            }
                            break;
                        default:
                            Console.WriteLine("Ungültige Operation.");
                            break;
                    }

                    Console.WriteLine($"Ergebnis: {ergebnis}");
                    Console.WriteLine("------------------------------");
                }
                catch
                {
                    Console.WriteLine("Ein Fehler ist aufgetreten.");
                }
            }
        }
    }
}