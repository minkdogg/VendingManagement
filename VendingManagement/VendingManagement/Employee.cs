using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Employee
    {
        protected string fName;
        protected string lName;
        protected string position = "General";
        protected string employeeID;
        protected float payRate = 0;
        protected string location;
        protected string fullName;
        protected DateTime dateStarted;


        public Employee(string fName, string lName, string employeeID, string location)
        {
            this.fullName = fName + " " + lName;
            this.fName = fName;
            this.lName = lName;
            this.employeeID = employeeID;
            this.location = location;
            this.dateStarted = DateTime.Today;
            
        }

        
        public string FullName
        {
            get { return fullName;}
        }

        public DateTime DateStarted
        {
            get { return dateStarted; }
            set { dateStarted = value; }
        }

        public string FName
        {
            get { return fName; }
            set {
                fName = value;
                fullName = fName + " " + lName;
                    }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                lName = value;
                fullName = fName + " " + lName;
            }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public float Payrate
        {
            get { return payRate; }
            set { payRate = value; }
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }


    }
}
