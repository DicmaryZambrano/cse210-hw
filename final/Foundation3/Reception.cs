using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation3
{
    class Reception : Event
    {
        private string _email;

        public Reception(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string email
        ) : base(title, description, date, time, address)
        {
            _email = email;
        }

        public override string getFullDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is a Reception\n\nRSVP email: {_email}\n\n{getTitle()}\n\nEvent Date:{getDate()}          Event Starts:{getTime()}\n\n{getDescription()}\n\nLocation:\n\n{address}";
            return detailsString;
        }  

        public override string getShortDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is a Reception\n\n{getTitle()}\n\nDate:{getDate()}";
            return detailsString;
        }  
    }
}