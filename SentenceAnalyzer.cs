using Abstractions;

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
        /// Skriver ut det tredje ordet
        /// </summary>
        public void PrintThirdWord()
        {
            _ui.Print("Det tredje ordet");
            _ui.Print("Ange en mening med minst tre ord.");
            var input = _ui.GetInput();

            var words = input.Split(' ');



            _ui.Print(words[2]);
        }
    }
}