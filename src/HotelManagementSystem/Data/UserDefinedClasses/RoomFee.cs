using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class RoomFee : Fee
    {
        private string _roomID;

        public string CustomerRoomID
        {
            get { return _roomID; }
            set { _roomID = value; }
        }

        public override void calculateFee()
        {

        }
    }
}
