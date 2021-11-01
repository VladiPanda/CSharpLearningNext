using System;
using System.IO;

// Использвание BufferedStream.

// Буфер — это блок байтов памяти, который используется для кэширования данных, 
// тем самым уменьшая количество обращений к операционной системе.
// Таким образом, буферизация повышает скорость чтения и записи.

// Методы Read и Write класса BufferedStream обслуживают буфер автоматически.


namespace BufferedStream
{
    class Program
    {
        static void Main()
        {            
            FileStream file = File.Create(@"D:\test.txt");
            System.IO.BufferedStream buffered = new System.IO.BufferedStream(file);
		   
            StreamWriter writer = new StreamWriter(buffered);

            writer.WriteLine("Some data...");
            
            buffered.Position = 0;

            // При сбросе буфера buffered, данные из него попадают в связанный поток - file.
            writer.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}