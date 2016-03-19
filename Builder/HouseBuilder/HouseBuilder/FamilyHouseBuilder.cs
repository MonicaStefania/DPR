using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class FamilyHousebuilder:IHouseBuilder
    {
        House house = new House();
        public void AddExtraFeature()
        {
            house.ExtraFeature = "playground for kids";
        }

        public void AddFloorsNb()
        {
            house.FloorNb = 2;
        }

        public void AddPrice()
        {
            house.Price = 50.000;
        }

        public void AddSize()
        {
            house.Size = 220;
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
            house.NbOfBedrooms = 5;
        }
    }
}
