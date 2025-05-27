using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.UI
{
    /// <summary>
    /// Klass som vet hur man skriver till konsolen
    /// </summary>
    internal class ConsoleUI : IUI
    {

        /// <summary>
        /// om console.readline inte är null används det.
        //Annars används string.empty
        /// </summary>
        /// <returns></returns>
        public string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        public void Print(string message)
        {
           Console.WriteLine(message);
        }

        public void PrintSingleLine(string word)
        {
            Console.Write(word);
        }
    }
}
