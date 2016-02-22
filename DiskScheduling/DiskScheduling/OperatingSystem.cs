using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class OperatingSystem
    {
        IDiskSchedule dk;

        public OperatingSystem(IDiskSchedule d)
        {
            dk = d;
        }

        public int[] performDiskSchedule
        {
            get
            {
                return dk.Schedule();
            } 
        }

    }


}
