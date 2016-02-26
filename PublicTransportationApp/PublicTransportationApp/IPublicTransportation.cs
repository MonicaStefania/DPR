using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
   public interface IPublicTransportation
    {
         void Attach(IPublicTransportation obj);
         void Detach(IPublicTransportation obj);
        void Notify(IPublicTransportation obj);
        bool isDelayed { get; set; }
        string From { get; set; }
        string To { get; set; }
        int Hour { get; set; }
        int Minutes { get; set; }
         int Delay { get; set; }
        string State(IPublicTransportation obj);
    }
}
