using System;
using System.Collections;

// HybridDictionary - Рекомендуется к использованию в тех случаях, когда невозможно определить размер коллекции заранее.

namespace HybridDictionary
{
    class Program
    {
        static void Main()
        {
            var emailLookup = new System.Collections.Specialized.HybridDictionary();

            emailLookup["sbishop@contoso.com"] = "Bishop, Scott";
            emailLookup["chess@contoso.com"] = "Hell, Christian";
            emailLookup["djump@contoso.com"] = "Jump, Dan";

            foreach (DictionaryEntry entry in emailLookup)
            {
                Console.WriteLine(entry.Value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}