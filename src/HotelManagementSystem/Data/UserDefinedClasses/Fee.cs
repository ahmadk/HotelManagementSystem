using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public abstract class BaseFee
    {
        public Guid ID { get; set; }
        public Guid RoomID { get; set; }
        public virtual Room Room { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public Guid MoneyTypeID { get; set; }
        public decimal Discount { get; set; }
    }

    public class Fee : BaseFee
    {

    }
}
