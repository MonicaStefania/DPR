using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
    class TrafficMonitor
    {
       public IPublicTransportation pb { get; set; }
       public IObserver observe { get; set; }
  
    }
}
