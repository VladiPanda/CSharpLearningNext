using System;

// Получение информации о дисках.

namespace DriveInfo
{
    class Program
    {
        static void Main()
        {
            // Создание коллекции дисков.
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();

            // Вывод информации о дисках компьютера.
            foreach (System.IO.DriveInfo drive in drives)
            {
                Console.WriteLine("Drive: {0} Type: {1}", drive.Name, drive.DriveType);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}