using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class FIFO:DiskSchedule
    {
        int[] numbers = new int[] { 24, 45, 3, 47, 100, 6, 2, 13, 10, 11, 12, 47, 48, 28, 50, 10, 62 };

        public int[] Schedule()
        {
            int a = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = numbers[i++];
            }
            numbers[numbers.Length] = a;
            return numbers;
        }
    }
}
