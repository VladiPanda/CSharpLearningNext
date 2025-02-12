﻿using System;
using System.IO;

// Создание директорий.

namespace InputOutput_03
{
    class Program
    {
        static void Main()
        {            
            var directory = new DirectoryInfo(@"D:\TESTDIR");
            //Console.WriteLine(directory.FullName);
            // Создание в TESTDIR новых подкаталогов.
            if (directory.Exists)
            {
                // Создаем D:\TESTDIR\SUBDIR.
                directory.CreateSubdirectory("SUBDIR");

                // Создаем D:\TESTDIR\MyDir\SubMyDir.
                directory.CreateSubdirectory(@"MyDir\SubMyDir");

                Console.WriteLine("Директории созданы.");
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}