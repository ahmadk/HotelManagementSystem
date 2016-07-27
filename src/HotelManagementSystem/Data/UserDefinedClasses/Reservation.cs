using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public class Reservation
    {
        private Room _customerRoom;
        private DateTime _registrationDate;
        private DateTime _entryDate;
        private DateTime _exitDate;
        private string _registrationID;

        public Room CustomerRoom {
            get { return _customerRoom; }
            set { _customerRoom = value; }
        }
        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }
        public DateTime EntryDate
        {
            get { return _entryDate; }
            set { _entryDate = value; }
        }
        public DateTime ExitDate
        {
            get { return _exitDate; }
            set { _exitDate = value; }
        }
        public string RegistrationID
        {
            get { return _registrationID; }
            set { _registrationID = value; }
        }
    }
}
