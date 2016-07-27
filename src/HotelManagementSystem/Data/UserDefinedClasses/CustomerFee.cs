using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class CustomerFee : Fee
    {
        private Customers _customer;
        private float _customerFee;
        private Reservation _reservation;

        public Customers Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
     
        public Reservation CustomerReservation
        {
            get { return _reservation; }
            set { _reservation = value; }
        }
    }
}
