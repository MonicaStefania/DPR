using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class ShortestSeekTime:DiskSchedule
    {
        int[] numbers = new int[] { 24, 45, 3, 47, 100, 6, 2, 13, 10, 11, 12, 47, 48, 28, 50, 10, 62 };
        public int[] Schedule()
        {
            int a = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {

                int x = a - numbers[i + 1];
                int y = a - numbers[i - 1];
                if (x < 0)
                {
                    x = x * (-1);
                }
                if (y < 0)
                {
                    y = y * (-1);
                }
                if (x < y)
                {
                    a = numbers[i + 1];
                }
                else
                {
                    a = numbers[i - 1];
                }
            }
            return numbers;
        }
    }
}
