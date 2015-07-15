using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class City
    {
        string name;
        string location;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        
        public City(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

    }
}
