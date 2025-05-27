using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Main
    {
        private IUI _ui;

        public Main(IUI ui)
        {
            _ui = ui;
        }

        public void Run()
        {
            Printmenu();
        }

        /// <summary>
        /// Huvudmenyn som skriver ut val och användaren väljer vilken klass och metod man ska skickas vidare till.
        /// </summary>
        private void Printmenu()
        {
            while (true)
            {
                _ui.Print("Välkommen till huvudmenyn. \nSkriv in en siffra för att testa olika funktioner.");
                _ui.Print("0. Exit\n1. Beräkna biljettpris \n2. Repetera ord \n3. Tredje ordet");

                var input = _ui.GetInput();
                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        var ticketCalculator = new TicketCalculator(_ui);
                        ticketCalculator.GetTicketCalculationMode();
                        break;
                    case "2":
                        var repeater = new Repeater(_ui);
                        repeater.Repeating();
                        break;
                    case "3":
                        var sentenceAnalyzer = new SentenceAnalyzer(_ui);
                        sentenceAnalyzer.PrintThirdWord();
                        break;

                    default:
                        _ui.Print("Felaktig input\n");
                        break;
                };
            }; 
        }
    }
}
