﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class RoomDescription
    {
        public Guid ID { get; set; }
        public Guid RoomTypeID { get; set; }
        public string Description { get; set; }
    }
}
