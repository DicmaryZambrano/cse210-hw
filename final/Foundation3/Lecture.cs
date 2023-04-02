using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation3
{
    class Lecture : Event
    {
        private string _speaker;
        private string _capacity;

        public Lecture(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string speaker,
            string capacity
        ) : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string getFullDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is a Lecture\n\nSpeaker:{_speaker}                  Capacity:{_capacity}\n\n{getTitle()}\n\nEvent Date:{getDate()}          Event Starts:{getTime()}\n\n{getDescription()}\n\nLocation:\n\n{address}";
            return detailsString;
        }  

        public override string getShortDetails() {
            string address = getAddress().getStringAddress();
            string detailsString = $"This is a Lecture\n\n{getTitle()}\n\nDate:{getDate()}";
            return detailsString;
        }  
    }
}