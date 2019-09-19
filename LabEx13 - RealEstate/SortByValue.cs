using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx13___RealEstate
{
    class SortByValue : IComparer<Building>
    {
        /// <summary>
        /// A method used to sort buildings by price, wasn't actually used in the lab but was good practice.
        /// Called with buildingList.Sort(new SortByValue()); where buildingList is a list of buildings.
        /// </summary>
        /// <param name="b1">The building be compared</param>
        /// <param name="b2">The building compared to</param>
        /// <returns></returns>
        public int Compare(Building b1, Building b2)
        {
            return b1.Price.CompareTo(b2.Price);
        }
    }
}
