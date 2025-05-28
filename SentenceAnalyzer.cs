using Abstractions;
using System.Text.RegularExpressions;

namespace ControlFlow
{
    internal class SentenceAnalyzer
    {
        private readonly IUI _ui;

        public SentenceAnalyzer(IUI ui)
        {
            _ui = ui;
        }

        /// <summary>
        /// Man anger en mening med minst 3 ord. Regex kollar så att det är bokstäver och mellanrum.
        /// Inuti if(isValid) delar man upp strängen och kollar så att längden är >= 3 och skriver ut det 3e ordet i meningen.
        /// Metoden funkar också för flera mellanslag mellan orden.
        /// Om allt ser bra ut så skickas mna till huvudmenyn, annars fortsätter loopen tills rätt input.
        /// </summary>
        public void PrintThirdWord()
        {
            while (true)
            {
                _ui.Print("Ange en mening med minst tre ord.");
                var input = _ui.GetInput();

                // Regex som tar bort dubbla mellanslag
                input = Regex.Replace(input, @"\s+", " ");

                //Regex kollar så att det är bokstäver och mellanrum
                bool isValid = Regex.IsMatch(input, @"^[a-zA-ZåäöÅÄÖ ]+$");
                if (isValid)
                {
                    var words = input.Split(' ');

                    if (words.Length >= 3)
                    {
                        _ui.Print(words[2]);
                    }
                    else
                    {
                        _ui.Print("Meningen måste vara minst tre ord.");
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