using Abstractions;

namespace ControlFlow
{
    internal class TicketCalculator
    {
        private readonly IUI _ui;

        public TicketCalculator(IUI ui)
        {
            _ui = ui;
        }

        /// <summary>
        /// Uppmanar användaren att välja biljett och hanterar felaktig input.
        /// </summary>
        public void GetTicketCalculationMode()
        {
            bool shouldRepeat = true;
            while (shouldRepeat)
            {
                _ui.Print("\nDu har valt att räkna ut din ålder, vill du räkna för en person eller ett helt sällskap?");
                _ui.Print("1. En Person \n2. Sällskap");
                string choice = _ui.GetInput();

                switch (choice)
                {
                    case "1":
                        shouldRepeat = false;
                        DecideAge();
                        break;
                    case "2":
                        shouldRepeat = false;
                        CalculateAll();
                        break;
                    default:
                        _ui.Print("Ogiltigt val i undermenyn");
                        break;
                }
            }
        }

/// <summary>
/// Bestämmer pris baserat på ålder och returnerar priset.
/// Kollar även så man inte skriver in felaktig input.
/// </summary>
        public int DecideAge()
        {
            int age;
            while (true)
            {
                //nästlad if sats
                _ui.Print("\nHur gammal är du? Skriv in din ålder i siffror.");
                var input = _ui.GetInput();
                if (!int.TryParse(input, out age))
                {
                    _ui.Print("Ogiltig ålder, försök igen");
                }
                else
                {
                    break;
                }
            }
            if( age < 5 || age > 100)
            {
                _ui.Print("Gratis\n");
                return 0;
            }

            if (age < 20)
            {
                _ui.Print("Ungdomspris: 80 kr\n");
                return 80;
            }
            else
            {
                if (age > 64)
                {
                    _ui.Print("Pensionärspris: 90 kr\n");
                    return 90;
                }
                else
                {
                    _ui.Print("Standardpris: 120 kr\n");
                    return 120;
                }
            }
        }

        /// <summary>
        /// Beräknar pris baserat på hur många man är i sällskapet och kollar så man är inte är 0 personer eller skriver in bokstäver.
        /// Beräknar totala priset för x antal personer och skriver ut summan.
        /// </summary>
        public void CalculateAll()
        {
            _ui.Print("\nHur många personer är ni i sällskapet?");
            var input = _ui.GetInput();
            if(!int.TryParse(input, out int numberOfPeople) || numberOfPeople < 1)
            {
                _ui.Print("Ogiltigt antal, försök igen");
                CalculateAll();
                return;
            }

            int total = 0;
            for (int i = 1; i <= numberOfPeople; i++)
            {
                total += DecideAge();
            }
            _ui.Print($"\nTotalt pris för {numberOfPeople} personer: {total} kr\n");

            _ui.Print("\nTryck Enter för att återgå till huvudmenyn");
            _ui.GetInput();
        }
    }
}