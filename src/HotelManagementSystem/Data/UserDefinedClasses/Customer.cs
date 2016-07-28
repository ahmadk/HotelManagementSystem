using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
            CustomerFees = new HashSet<CustomerFee>();
        }
        public Guid ID { get; set; }
        public Guid ReservationID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<CustomerFee> CustomerFees { get; set; }
    }
}
