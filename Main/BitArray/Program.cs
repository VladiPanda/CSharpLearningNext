using System;

namespace BitArray
{
    class Program
    {
        static void Main()
        {
            System.Collections.BitArray bits = new System.Collections.BitArray(3);
            bits[0] = false;
            bits[1] = true;
            bits[2] = false;
            Console.WriteLine(bits.Length);

            // Для изменения размера необходимо воспользоваться свойством Length.
            bits.Length = 4;
            bits[3] = true;
            Console.WriteLine(bits.Length);

            // Delay.
            Console.ReadKey();
        }
    }
}