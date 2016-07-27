using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Customers
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public int otherID { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public int reservationID { get; set; }
    }
}
