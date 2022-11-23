using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastfoodManagementFinal.Models
{
    public class Customer
    {
        public Customer()
        {

        }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSex { get; set; }
        public string CustomerPhone { get; set; }
        public List<Bill> CustomerBills { get; set; }
        public int CustomerTotal { get; set; }
        public string CustomerRank { get; set; }
        public string Address { get; set; }
    }
}
