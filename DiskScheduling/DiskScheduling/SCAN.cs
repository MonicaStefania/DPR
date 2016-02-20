using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class SCAN : DiskSchedule
    {
        public int[] numbers = new int[] { 24, 45, 3, 47, 100, 6, 2, 13, 10, 11, 12, 47, 48, 28, 50, 10, 62 };
        public int[] Schedule()
        {
            List<int> sorted = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                sorted.Add(numbers.Min());
                numbers = numbers.Except(new int[] { numbers.Min() }).ToArray();
            }
            return sorted.ToArray();
        }
    }
    
    }

