using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation2
{
    class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _zip;
        private string _country;

        public Address(
            string street,
            string city,
            string state,
            string zip,
            string country
        ) 
        {
            _street = street;
            _city = city;
            _state = state;
            _zip = zip;
            _country = country;
        }

        public bool isUSA() {
            return _country.ToUpper() == "USA";
        }

        public string getStringAddress() {
            return $"{_street}\n{_city}, {_state} {_zip}\n{_country}";
        }
    }
}
