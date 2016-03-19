using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class House
    {
        public int Size { get; set; }
        public int FloorNb { get; set; }
        public int NbOfBedrooms { get; set; }
        public int NbOfBathrooms { get; set; }
        public double Price { get; set; }
        public String ExtraFeature { get; set; }

        public override string ToString()
        {
            return Size + " square meeters with " + FloorNb + " floors, " + NbOfBedrooms + " bedrooms, " + NbOfBathrooms + " bathrooms for " + Price + " euro.\n The house also comes with " + ExtraFeature;
        }
    }
}
