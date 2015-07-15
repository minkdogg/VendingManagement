using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Vehicle
    {

        protected string vehicleID;
        protected string make = "";
        protected string model = "";
        protected int year = 0;
        protected string location;
        protected int mileageCost;
        
        public Vehicle(string vehicleID, string location, int mileageCost)
        {
            this.vehicleID = vehicleID;
            this.location = location;
            this.mileageCost = mileageCost;
           
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int MileageCost
        {
            get { return mileageCost; }
            set { mileageCost = value; }
        }

  

        public float getTripCost(float miles)
        {
            return miles * mileageCost;
        }







    }
}
