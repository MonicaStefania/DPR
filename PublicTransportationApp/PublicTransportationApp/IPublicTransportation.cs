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
        string State();
    }
}
