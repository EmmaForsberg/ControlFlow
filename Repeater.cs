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
        /// Upprepa text 10 gånger
        /// </summary>
        public void Repeating()
        {
            while (true)
            {
                _ui.Print("Upprepa gånger 10");
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
                    continue;
                }
            }

        }
    }
}