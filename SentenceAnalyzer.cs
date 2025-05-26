namespace ControlFlow
{
    internal class SentenceAnalyzer
    {
        /// <summary>
        /// Skriver ut det tredje ordet
        /// </summary>
        public static void PrintThirdWord()
        {
            Console.WriteLine("Det tredje ordet");
            Console.WriteLine("Ange en mening med minst tre ord.");
            var input = Console.ReadLine();

            var words = input.Split(' ');

            Console.WriteLine(words[2]);
        }
    }
}