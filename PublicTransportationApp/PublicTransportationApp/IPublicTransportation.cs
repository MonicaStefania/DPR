using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
   public interface IPublicTransportation
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
        bool isDelayed { get; set; }
        string From { get; set; }
        string To { get; set; }
        int Hour { get; set; }
        int Minutes { get; set; }
        int Delay { get; set; }
        bool State();
    }
}
