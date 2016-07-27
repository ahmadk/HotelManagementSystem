using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data.UserDefinedClasses
{
    public abstract class Fee
    {
        private string _moneyType;
        private float _price;

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string MoneyType
        {
            get { return _moneyType; }
            set { _moneyType = value; }
        }

    }
}
