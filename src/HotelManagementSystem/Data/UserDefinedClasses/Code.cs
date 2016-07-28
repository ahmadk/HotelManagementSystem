using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Code
    {
        public Code()
        {
            Employees = new HashSet<Employee>();
            RoomDescriptions = new HashSet<RoomDescription>();
            Fees = new HashSet<Fee>();
        }
        public Guid ID { get; set; }
        public Guid CodesetID { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<RoomDescription> RoomDescriptions { get; set; }
        public ICollection<Fee> Fees { get; set; }
    }
}
