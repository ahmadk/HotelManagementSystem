using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Room
    {
        public Guid ID { get; set; }
        public string RoomNo { get; set; }
        public string Floorno { get; set; }
        public int Capacity { get; set; }
    }
}
