using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class OperatinSystem
    {
        DiskSchedule dk;

        public OperatinSystem(DiskSchedule d)
        {
            d = dk;
        }
        public void setDiskSchedule()
        {
            //idk if there should be smth here
        }
        public int[] performDiskSchedule()
        {
            return dk.Schedule();
        }

    }


}
