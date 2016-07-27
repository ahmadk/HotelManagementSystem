using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class RoomFee
    {
        public Guid ID { get; set; }
        public Guid RoomID { get; set; }
        public Guid CustomerRoomID { get; set; }
        public decimal Fee { get; set; }
    }
}