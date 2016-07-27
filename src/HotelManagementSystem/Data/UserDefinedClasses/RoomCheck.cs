using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class RoomCheck
    {
        public Guid ID { get; set; }
        public Guid CheckedByID { get; set; }
        public Guid  ReservationId { get; set; }
        public string CheckInfo { get; set; }
    }
}