using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Codeset
    {
        public Codeset()
        {
            Codes = new HashSet<Code>();
        }

        public Guid ID { get; set; }
        public string Description { get; set; }

        public ICollection<Code> Codes { get; set; }
    }
}
