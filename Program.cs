using Abstractions;
using ControlFlow.UI;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUI ui = new ConsoleUI();
            Main main = new Main(ui);
            main.Run();

            Console.Read();
        }
    }
}