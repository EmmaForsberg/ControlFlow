using Abstractions;
using System.Text.RegularExpressions;

namespace ControlFlow
{
    internal class Repeater
    {
        private readonly IUI _ui;

        public Repeater(IUI ui)
        {
            _ui = ui;
        }

        /// <summary>
        /// Metod som upprepar text 10 gånger. 
        /// Den använder Regex för att kolla så input är text och inte siffror eller siffror tillsammans med text.
        /// Om isValid så går den in i loopen och skriver ut texten 10 gånger, sedan skickas man tillbaka till huvudmenyn.
        /// Vid felaktig input börjar while loopen om.
        /// </summary>
        public void Repeating()
        {
            while (true)
            {
                _ui.Print("Ange texten du vill ska upprepas 10 gånger:");
                var input = _ui.GetInput();

                bool isValid = Regex.IsMatch(input, @"^[a-zA-ZåäöÅÄÖ]+$");
                if (isValid)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        _ui.PrintSingleLine($"{i}. {input} ");
                    }
                    _ui.Print("\nTryck Enter för att återgå till huvudmenyn");
                    _ui.GetInput();
                    break;
                }
                else
                {
                    _ui.Print("Felaktig input. Försök igen:");
                    continue;
                }
            }
        }
    }
}