using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx13___RealEstate
{
    /// <summary>
    /// Superclass of House and Business
    /// </summary>
    abstract class Building : IComparable<Building>
    {
        //Reference ID for the building
        private string refID;
        //Physical location of the building in the non-existent city of Gydambuka
        private string location;
        //If the building is for rent "R" or sale "S"
        private string transactionType;
        //The type of building "B" for business, "H" for house
        private string buildType;
        //Either purchase price, or weekly rent.
        private int price;

        public int Price
        {
            get { return price; }
        }

        public string BuildType
        {
            get { return buildType; }
        }


        public string TransactionType
        {
            get {
                if (transactionType == "R") { return "Rent"; }
                return "Sale"; }
        }


        public string Location
        {
            get { return location; }
        }

        public string RefID
        {
            get { return refID; }
        }

        /// <summary>
        /// Natural sort order of a building, based on reference ID, used when sorting.
        /// </summary>
        /// <param name="that">The building being compared to.</param>
        /// <returns></returns>
        public int CompareTo(Building that)
        {
            return this.RefID.CompareTo(that.RefID);
        }


        public Building(string refID, string location, string transactionType, string buildType, int price)
        {
            this.refID = refID;
            this.location = location;
            this.transactionType = transactionType;
            this.buildType = buildType;
            this.price = price;
        }
    }
}
