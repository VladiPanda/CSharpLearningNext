using System;
using System.Collections;

namespace Hashtable_03
{
    class Program
    {
        static void Main()
        {
            var duplicates = new Hashtable();

            duplicates["First"] = "1st";
            duplicates["First"] = "the first";

            Console.WriteLine(duplicates.Count);

            // Delay.
            Console.ReadKey();
        }
    }
}