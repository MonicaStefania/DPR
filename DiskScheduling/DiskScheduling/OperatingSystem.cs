using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiskScheduling;

namespace DiskScheduling
{   
    class OperatingSystem
    {
        public IDiskSchedule dkSchedule { get; set; }

                             


        public int[] performDiskSchedule
        {
            get
            {
                return dkSchedule.Schedule();
            } 
        }

    }


}
