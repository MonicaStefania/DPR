using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class CabinHouseBuilder:IHouseBuilder
    {
        House house = new House();
        public void AddExtraFeature()
        {
            house.ExtraFeature = "fireplace";
        }

        public void AddFloorsNb()
        {
            house.FloorNb = 1;
        }

        public void AddPrice()
        {
            house.Price = 30.000;
        }

        public void AddSize()
        {
            house.Size = 100;
        }

        public House GetHouse()
        {
            return house;
        }

        public void AddNbOfBathrooms()
        {
            house.NbOfBathrooms = 1;
        }

        public void AddNbOfBedrooms()
        {
            house.NbOfBedrooms = 2;
        }
    }
}
