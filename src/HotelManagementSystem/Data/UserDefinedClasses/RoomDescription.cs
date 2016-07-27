using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class RoomDescription
    {
        public int Fk_RoomId { get; set; }
        public string RoomType { get; set; }
        public string Description { get; set; }
    }
}
