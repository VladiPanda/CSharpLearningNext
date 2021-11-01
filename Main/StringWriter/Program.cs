using System;

// Запись в поток.

namespace StringWriter
{
    class Program
    {
        static void Main()
        {
            // StringWriter - обертка над StringBuilder
            var writer = new System.IO.StringWriter();
            writer.WriteLine("Hello all ");
            writer.Write("This is a multi-line ");
            writer.WriteLine("text string.");
            
            Console.WriteLine(writer.ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}