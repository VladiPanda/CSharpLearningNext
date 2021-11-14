using System;
using System.Threading;

namespace WaitHandle
{
    class Program
    {
        static System.Threading.WaitHandle[] events = new System.Threading.WaitHandle[]
        {
            new AutoResetEvent(false), // 0
            new AutoResetEvent(false)  // 1
        };

        static void Main()
        {
            // Помещение двух задач в пул потоков. 
            ThreadPool.QueueUserWorkItem(Task1, events[0]);
            ThreadPool.QueueUserWorkItem(Task2, events[1]);

            Console.WriteLine("Ожидание завершения обеих задач.");
            System.Threading.WaitHandle.WaitAll(events);

            // Помещение двух задач в пул потоков. 
            ThreadPool.QueueUserWorkItem(Task1, events[0]);
            ThreadPool.QueueUserWorkItem(Task2, events[1]);

            Console.WriteLine("\nОжидание завершения одной из задач.");
            // [вторая задача Task2 продолжит выполнение параллельно с первичнм потоком]
            int index = System.Threading.WaitHandle.WaitAny(events);
            Console.WriteLine("\nЗадача Task{0} завершилась первой.", index + 1);

            // Delay
            Console.ReadKey();
        }

        static void Task1(Object state)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1 ");
                Thread.Sleep(500);
            }
            (state as AutoResetEvent).Set();
        }

        static void Task2(Object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("2 ");
                Thread.Sleep(500);
            }
            (state as AutoResetEvent).Set();
        }
    }
}