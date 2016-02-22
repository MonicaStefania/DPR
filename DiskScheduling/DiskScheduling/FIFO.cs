using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    public class FIFO:IDiskSchedule
    {
        public int[] numbers = new int[] { 24, 45, 3, 49, 100, 6, 2, 13, 16, 11, 12, 47, 48, 28, 50, 10, 62 };

        public int[] Schedule()
        {
            int a = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i++];
            }
          //  numbers[numbers.Length - 1] = a; 
            return numbers;
        }
    }
}
// 62