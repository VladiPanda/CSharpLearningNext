﻿using System;
using UserCollection_2.UserCollection;

namespace UserCollection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var сollection = new UserCollection<Element>();

            сollection[0] = new Element(1, 2);
            сollection[1] = new Element(3, 4);
            сollection[2] = new Element(5, 6);
            сollection[3] = new Element(7, 8);
      
            foreach (var element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (var element in сollection)
            {
                Console.WriteLine("{0}, {1}", element.FieldA, element.FieldB);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}