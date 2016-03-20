using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class CountryHouseBuilder:IHouseBuilder
    {
        House house = new House();
        public void AddExtraFeature()
        {
            house.ExtraFeature = "big garden";
        }

        public void AddFloorsNb()
        {
            house.FloorNb = 1;
        }

        public void AddPrice()
        {
            house.Price = 20000;
        }

        public void AddSize()
        {
            house.Size = 150;
        }

        public House GetHouse()
        {
            return house;
        }

        public void AddNbOfBathrooms()
        {
            house.NbOfBathrooms = 2;
        }

        public void AddNbOfBedrooms()
        {
            house.NbOfBedrooms = 4;
        }
    }
}
