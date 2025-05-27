using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.UI
{
    internal class ConsoleUI : IUI
    {
        /// <summary>
        /// Metod som garanterar att jag alltid får tillbaka en icke-null string. 
        /// </summary>
        /// <returns></returns>
        public string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        /// <summary>
        /// Tar en sträng och skriver ut den.
        /// </summary>
        /// <param name="message"></param>
        public void Print(string message)
        {
           Console.WriteLine(message);
        }

        /// <summary>
        /// Skriver ut text som ska vara på samma rad
        /// </summary>
        /// <param name="word"></param>
        public void PrintSingleLine(string word)
        {
            Console.Write(word);
        }
    }
}
