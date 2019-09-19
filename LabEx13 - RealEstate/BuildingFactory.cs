using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx13___RealEstate
{
    class BuildingFactory
    {
        /// <summary>
        /// Takes a line of text and returns either a House, Business object or null if buildingType is invalid
        /// </summary>
        /// <param name="buildData">A line of text imported from a text file.</param>
        /// <returns></returns>
        public static Building createBuilding(string buildData)
        {
            string[] buildDataArr = buildData.Split(',');
            string refID = buildDataArr[0];
            string location = buildDataArr[1];
            string saleType = buildDataArr[2];
            string buildingType = buildDataArr[3];
            int price = int.Parse(buildDataArr[4]);

            if (buildingType == "H")
            {
                //create House
                int numBedrooms = int.Parse(buildDataArr[5]);
                int garageCapacity = int.Parse(buildDataArr[6]);
                int area = int.Parse(buildDataArr[7]);

                Building houseEntry = new House(refID, location, saleType, buildingType, price, numBedrooms, garageCapacity, area);
                return houseEntry;
            }//if

            else if (buildingType == "B")
            {
                //create Business
                string businessType = buildDataArr[5];
                Building businessEntry = new Business(refID, location, saleType, buildingType, price, businessType);
                return businessEntry;
            }//elif

            //buildingType was invalid (not "B" or "H"), null returned
            return null;
        }
    }
}
