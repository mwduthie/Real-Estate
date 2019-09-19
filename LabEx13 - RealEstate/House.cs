using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx13___RealEstate
{
    class House : Building
    {
        //Number of bedrooms in the house
        private int numBedrooms;
        //Capacity of the garage, 0 for no garage.
        private int garageCapacity;
        //Size of the section in square meters.
        private int sectionSize;

        public int SectionSize
        {
            get { return sectionSize; }
        }


        public int GarageCapacity
        {
            get { return garageCapacity; }
        }


        public int NumBedrooms
        {
            get { return numBedrooms; }
        }

        public override string ToString()
        {
            return string.Format("{0}: House in {1}, {2}: ${3}, BD: {4}, G: {5}, {6} sq m",
                RefID, Location, TransactionType, Price, NumBedrooms, GarageCapacity, SectionSize);
        }


        public House(string refID, string location, string transactionType,
            string buildType, int price, int numBedrooms, int garageCapacity, int sectionSize) : 
            base(refID, location, transactionType, buildType, price)
        {
            this.numBedrooms = numBedrooms;
            this.garageCapacity = garageCapacity;
            this.sectionSize = sectionSize;
        }

    }
}
