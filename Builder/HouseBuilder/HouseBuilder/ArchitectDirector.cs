using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class ArchitectDirector
    {
        public void BuildHouse(IHouseBuilder hb)
        {
            hb.AddExtraFeature();
            hb.AddFloorsNb();
            hb.AddPrice();
            hb.AddSize();
            hb.AddNbOfBedrooms();
            hb.AddNbOfBathrooms();
        }
    }
}
