using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class SCAN : IDiskSchedule
    {
        public int[] numbers = new int[] { 24, 45, 3, 49, 100, 6, 2, 13, 16, 11, 12, 47, 48, 28, 50, 10, 62 };
        public int[] Schedule()
        {
            List<int> sorted = new List<int>();
            sorted=numbers.ToList();
            sorted.Sort();
            return sorted.ToArray();
        }
    }
    
    }

