﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    public interface DiskSchedule
    {
        int[] Schedule();
    }
}