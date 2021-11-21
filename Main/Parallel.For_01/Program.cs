using System;
using System.Diagnostics;
using static System.Threading.Tasks.Parallel;

// Применение метода Parallel.For() для организации параллельно выполняемого цикла обработки данных.
// Пример выполнять через (CTRL+F5).

namespace Parallel.For_01
{
    class Program
    {
        static void Main()
        {
            int[] data = new int[100000000];

            Stopwatch timer = new Stopwatch();

            timer.Start();

            for (int i = 0; i < data.Length; i++)
            {
                // Инициализация данных в обычном цикле for.                
                data[i] = i * i * i / 123;
            }

            timer.Stop();
            Console.WriteLine("Обычный цикл for      : " + timer.ElapsedTicks);
            timer.Reset();

            Action<int> transform = (int i) => { data[i] = i * i * i / 123; };

            timer.Start();

            // Инициализация данных в параллельном цикле for.
            For(0, data.Length, transform);

            timer.Stop();
            Console.WriteLine("Параллельный цикл for : " + timer.ElapsedTicks);

            // Внимание!
            // Выполнение метода Main() приостанавливается, 
            // пока не произойдет завершение работы метода For().

            Console.WriteLine("Основной поток завершен.");
        }
    }
}