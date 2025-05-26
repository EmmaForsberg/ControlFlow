namespace ControlFlow
{
    internal class TicketCalculator
    {

        public static void GetTicketCalculationMode()
        {
            Console.WriteLine("Du har valt att räkna ut din ålder, vill du räkna för 1 person eller ett helt sällskap?");
            Console.WriteLine("1. 1 Person \n2. Sällskap");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DecideAge();
                    break;
                case "2":
                    CalculateAll();
                    break;
                default:
                    Console.WriteLine("Ogiltigt val i undermenyn");
                    break;
            }

        }

        /// <summary>
        /// Frågar och bestämmer pris baserat på ålder
        /// </summary>
        /// <returns></returns>
        public static int DecideAge()
        {
            //nästlad if sats
            Console.WriteLine("Hur gammal är du? Skriv in din ålder i siffror.");
            var input = Console.ReadLine();
            var age = int.Parse(input);

            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80 kr");
                return 80;
            }
            else
            {
                if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90 kr");
                    return 90;
                }
                else
                {
                    Console.WriteLine("Standardpris: 120 kr");
                    return 120;
                }
            }
        }

        /// <summary>
        /// Beräknar pris baserat på hur många man är i sällskapet
        /// </summary>
        public static void CalculateAll()
        {
            int total = 0;
            // anger först hur många  i sällskapet
            // fråga sedan på ålder på var och en
            Console.WriteLine("Hur många personer är ni i sällskapet?");
            var input = Console.ReadLine();
            var numberOfPeople = int.Parse(input);

            for (int i = 1; i <= numberOfPeople; i++)
            {
                total += DecideAge();
            }
            Console.WriteLine($"Totalt pris för {numberOfPeople} personer: {total} kr");
        }
    }
}