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
        string state;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public City(string name, string state)
        {
            this.name = name;
            this.state = state;
        }

    }
}
