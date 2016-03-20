using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class VacationHouseBuilder : IHouseBuilder
    {
        House house=new House();
        public void AddExtraFeature()
        {
            house.ExtraFeature = "pool";
        }

        public void AddFloorsNb()
        {
            house.FloorNb = 2;
        }

        public void AddPrice()
        {
            house.Price = 40000;
        }

        public void AddSize()
        {
            house.Size = 200;
        }

        public House GetHouse()
        {
            return house;
        }

        public void AddNbOfBathrooms()
        {
            house.NbOfBathrooms = 3;
        }

        public void AddNbOfBedrooms()
        {
            house.NbOfBedrooms = 6;
        }
    }
}
