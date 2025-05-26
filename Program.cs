namespace ControlFlow
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Printmenu();
                Console.Read();
            }

            /// <summary>
            /// Skriver ut huvudmenyn med val
            /// </summary>
            private static void Printmenu()
            {
                bool istrue = true;

                do
                {
                    Console.WriteLine("Välkommen till huvudmenyn. \nSkriv in en siffra för att testa olika funktioner.");
                    Console.WriteLine("0\n1\n2\n3");

                    var input = Console.ReadLine();

                    switch (input)
                    {
                        case "0":
                            istrue = false;
                            Environment.Exit(0);
                            break;
                        case "1":
                            TicketCalculator.GetTicketCalculationMode();
                            break;

                        case "2":
                            Repeater.Repeating();
                            break;
                        case "3":

                            SentenceAnalyzer.PrintThirdWord();
                            break;

                        default:
                            Console.WriteLine("Felaktig input");
                            break;
                    }
                } while (istrue);
            }
        }
    }