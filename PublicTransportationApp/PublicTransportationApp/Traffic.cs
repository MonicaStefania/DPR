using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
    public class Traffic : IObserver
    {
        List<IPublicTransportation> subjects=new List<IPublicTransportation>();
        public Traffic(IPublicTransportation s)
        {
            s.Attach(this);
            subjects.Add(s);
           
        }
        public void Update()
        {
            foreach (IPublicTransportation s in subjects)
            {
                s.State();
            }
        }
    }
}
