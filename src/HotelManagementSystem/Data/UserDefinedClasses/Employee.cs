using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Employee
    {
        public Employee()
        {
            RoomChecks = new HashSet<RoomCheck>();
        }
        public Guid ID { get; set; }
        public Guid EmployeeTypeID { get; set; }
        public ICollection<RoomCheck> RoomChecks {get; set;}
    }
}