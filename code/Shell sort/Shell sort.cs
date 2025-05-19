using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shell_sort
{
    public class Shell_sort
    {
        public static long ShellSort(int[] array)
        {
            long iterations = 0;
            int gap = array.Length / 2;

            while(gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= gap) && (array[j - gap] >  array[j]))
                    {
                        var temp = array[j];
                        array[j] = array[j - gap];
                        array[j - gap] = temp;
                        j = j - gap;

                        iterations++;
                    }
                }
                gap = gap / 2;
            }
            return iterations;
        }
        
    }
}
