using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class Event
    {
        private int eventId;
        private string eventName;
        private string venue;
        private DateTime eventDate;
        private int maxAttendees;
        private int numAttendees;
        private string dateCreated;
        private Customer[] attendeeList;

        public Event(int eventId, string eventName, string venue, DateTime eventDate, int maxAttendees)
        {
            this.eventId = eventId;
            this.eventName = eventName;
            this.venue = venue;
            this.eventDate = eventDate;
            this.maxAttendees = maxAttendees;
            numAttendees = 0;
            attendeeList = new Customer[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getEventId() { return eventId; }
        public string getEventName() { return eventName; }
        public string getVenue() { return venue; }
        public int getMaxAttendees() { return maxAttendees; }
        public int getNumAttendees() { return numAttendees; }
        public string getEventInfo()
        {
            string s = "event Id: " + eventId + "\nEvent name: " + eventName;
            return s;
        }
        public bool addAttendee(Customer c)
        {
            if (numAttendees >= maxAttendees) { return false; }
            attendeeList[numAttendees] = c;
            numAttendees++;
            return true;
        }

        private int findAttendee(int custId)
        {
            for (int x = 0; x < maxAttendees; x++)
            {
                if (attendeeList[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removeAttendee(int custId)
        {
            int loc = findAttendee(custId);
            if (loc == -1)
                return false;
            attendeeList[loc] = attendeeList[numAttendees - 1];
            numAttendees--;
            return true;
        }

        public string getAttendees()
        {
            string s = "\nCustomers registered :";
            for (int x = 0; x < numAttendees; x++)
            {
                s = s + "\n" + attendeeList[x].getFirstName() + " " + attendeeList[x].getLastName();
            }
            return s;
        }
        public override string ToString()
        {
            string s = "Event ID : " + eventId + "\nName: " + eventName;
            s += "\nVenue: " + venue;
            s += "\nDate:" + eventDate;
            s += "\nRegistered Attendees:" + numAttendees;
            s += "\nAvailable spaces:" + (maxAttendees - numAttendees);
            s += getAttendees();
            return s;
        }

    }

}
