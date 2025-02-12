﻿using System;
using UserCollection_3.UserCollection;

// Создание простой пользовательской коллекции с использованием оператора yield.

namespace UserCollection_3
{
    class Program
    {
        static void Main()
        {
            var сollection = new UserCollection<Element>();

            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8);

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (Element element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}