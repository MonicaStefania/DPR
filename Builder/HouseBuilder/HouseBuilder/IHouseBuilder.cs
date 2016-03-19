using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    interface IHouseBuilder
    {
         void AddSize();
        void AddFloorsNb();
        void AddNbOfBedrooms();
        void AddNbOfBathrooms();
        void AddPrice();
        void AddExtraFeature();
        House GetHouse();
    }
}
