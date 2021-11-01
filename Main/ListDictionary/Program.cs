using System;
using System.Collections;

//ListDictionary - Подходит для хранения небольшого количества элементов, поскольку организована по принципу обычного массива.

namespace ListDictionary
{
    class Program
    {
        static void Main()
        {
            var emailLookup = new System.Collections.Specialized.ListDictionary();

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