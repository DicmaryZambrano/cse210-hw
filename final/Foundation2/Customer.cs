using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation2
{
    class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public bool LivesInUSA()
        {
            return _address.isUSA();
        }

        public string getName()
        { 
            return _name;
        }

        public string getAddress()
        {
            return _address.getStringAddress();
        }
    }
}
