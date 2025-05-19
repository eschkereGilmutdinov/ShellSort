using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Анализ производительности Shell Sort");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Размер\tВремя (мс)\tИтерации");

                for (int size = 100; size <= 10000; size += 100)
                {
                    int[] array = DataGenerator.GenerateRandomArray(size);

                    var stopwatch = Stopwatch.StartNew();
                    long iterations = Shell_sort.ShellSort(array);
                    stopwatch.Stop();

                    Console.WriteLine($"{size}\t{stopwatch.Elapsed.TotalMilliseconds:F2}\t\t{iterations}");
                }
            }
        }
    }
}
