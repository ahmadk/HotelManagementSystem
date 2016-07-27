﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class CustomerFee
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid ReservationID { get; set; }
        public decimal Fee;
    }
}