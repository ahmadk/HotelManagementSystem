using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Code
    {
        public Guid ID { get; set; }
        public Guid CodesetID { get; set; }
        public string Description { get; set; }
    }
}
