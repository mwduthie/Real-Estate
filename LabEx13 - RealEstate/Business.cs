using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx13___RealEstate
{
    class Business : Building
    {
        //The type of business the building is - accomodation, tourism, contractor, ect 
        private string businessType;

        public string BusinessType
        {
            get { return businessType; }
        }

        public override string ToString()
        {
            return string.Format("{0}: Business in {1}, {2}: ${3}, {4}", RefID, Location, TransactionType, Price, BusinessType);
        }

        public Business(string refID, string location, string transactionType,
            string buildType, int price, string businessType) : base(refID, location, transactionType, buildType, price)
        {
            this.businessType = businessType;
        }
    }
}
