namespace ControlFlow
{
    internal class Repeater
    {
        /// <summary>
        /// Uppretpa text 10 gånger
        /// </summary>
        public static void Repeating()
        {
            Console.WriteLine("Upprepa gånger 10");
            Console.WriteLine("Ange texten du vill ska upprepas 10 gånger:");
            var input = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ". " + input + " ");
            }
        }
    }
}