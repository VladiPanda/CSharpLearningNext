﻿using System;
using System.IO;

// Отслеживание изменений в системе.

namespace FileSystemWatcher_01
{
    class Program
    {
        static void Main()
        {
            // Создание наблюдателя и сосредоточение его внимания на системном диске.
            var watcher = new FileSystemWatcher { Path = @"D:\" };

            // Зарегистрировать обработчики событий.
            watcher.Created += new FileSystemEventHandler(WatcherChanged);
            watcher.Deleted += WatcherChanged;

            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;

            // Delay.
            var change = watcher.WaitForChanged(WatcherChangeTypes.All);
            Console.WriteLine(change.ChangeType);

            Console.ReadKey();
        }

        // Обработчик события.
        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
        }
    }
}