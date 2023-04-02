using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation3
{
    class OutdoorGathering : Event
    {
        private string _weatherStatement;

        public OutdoorGathering(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string weatherStatement
        ) : base(title, description, date, time, address)
        {
            _weatherStatement = weatherStatement;
        }

        public override string getFullDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is a OutdoorGathering\n\nWeather Statement: {_weatherStatement}\n\n{getTitle()}\n\nEvent Date:{getDate()}          Event Starts:{getTime()}\n\n{getDescription()}\n\nLocation:\n\n{address}";
            return detailsString;
        }  

        public override string getShortDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is a OutdoorGathering\n\n{getTitle()}\n\nDate:{getDate()}";
            return detailsString;
        }  
    }
}