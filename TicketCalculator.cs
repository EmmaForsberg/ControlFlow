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

        public void GetTicketCalculationMode()
        {
            bool shouldRepeat = true;
            while (shouldRepeat)
            {
                _ui.Print("\nDu har valt att räkna ut din ålder, vill du räkna för 1 person eller ett helt sällskap?");
                _ui.Print("1. 1 Person \n2. Sällskap");
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
        /// Frågar och bestämmer pris baserat på ålder
        /// </summary>
        /// <returns></returns>
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

            if (age < 20)
            {
                _ui.Print("Ungdomspris: 80 kr");
                return 80;
            }
            else
            {
                if (age > 64)
                {
                    _ui.Print("Pensionärspris: 90 kr");
                    return 90;
                }
                else
                {
                    _ui.Print("Standardpris: 120 kr");
                    return 120;
                }
            }
        }

        /// <summary>
        /// Beräknar pris baserat på hur många man är i sällskapet
        /// </summary>
        public void CalculateAll()
        {
            _ui.Print("Hur många personer är ni i sällskapet?");
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
        }
    }
}