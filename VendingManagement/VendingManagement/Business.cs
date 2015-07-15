using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingManagement
{
    public class Business
    {
        public List<string> Accounts = new List<string>();

        public Business()
        {
            this.Accounts.Add("Checking");
        }
    }
}
