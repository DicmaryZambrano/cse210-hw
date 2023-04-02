using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation3
{
    class Event
    {
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;

        public Event(
            string title,
            string description,
            string date,
            string time,
            Address address
        ) 
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        public string getTitle()
        {
            return _title;
        }
        public string getDescription()
        {
            return _description;
        }

        public string getDate()
        {
            return _date;
        }

        public string getTime()
        {
            return _time;
        }

        public Address getAddress()
        {
            return _address;
        }

        public string getStandadDetails() {
            string address = _address.getStringAddress();
            string detailsString = $"{_title}\n\n{_date}          {_time}\n\n{_description}\n\n{address}";
            return detailsString;
        }  

        public virtual string getFullDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is an Event\n\n{getTitle()}\n\nEvent Date:{getDate()}          Event Starts:{getTime()}\n\n{getDescription()}\n\nLocation:\n\n{address}";
            return detailsString;
        }  

        public virtual string getShortDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is an Event\n\n{getTitle()}\n\nDate:{getDate()}";
            return detailsString;
        }  

    }
}
