using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class EventHandler
    {
        private static readonly int maxEvents = 50;
        private Event[] events;
        private int numOfEvent;
        public EventHandler()
        {
            numOfEvent = 0;
            events = new Event[maxEvents];
        }
        public void EventOptions()
        {
            Console.Clear();
            while (true)
            {

                Console.WriteLine("Andrew's Event Managment Limited.");
                Console.WriteLine("Event Menu.");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1: Add Event");
                Console.WriteLine("2: View all Events");
                Console.WriteLine("3: View Event Details");
                Console.WriteLine("4: Return to the main menu.\n");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        AddEvent();
                        break;
                    case '2':
                        for (int i = 0; i < numOfEvent; i++)
                        {
                            Console.WriteLine(events[i].ToString());
                        }
                        break;
                    case '3':
                        findEvent();
                        break;
                    case '4':
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Entered input was incorrect.\nPlease try again.");
                        break;
                }
            }
        }
        private void AddEvent()
        {
            string name, venue, date = "";
            DateTime eventDate;
            int numOfAttendee = 10;
            Console.Clear();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter venue");
            venue = Console.ReadLine();
            do {
                Console.WriteLine("Enter date");
                date = Console.ReadLine();
            } while (!checkDate(date));
            eventDate = DateTime.Parse(date);
            Console.WriteLine("Enter number of attendees");
            if (!int.TryParse(Console.ReadLine(), out numOfAttendee))
            {
                Console.WriteLine("Error in input.\nDefault value added.");
            };

            events[numOfEvent] = new Event(numOfEvent, name, venue, eventDate, numOfAttendee);
            numOfEvent++;
        }
        private bool checkDate(string date)
        {
            DateTime temp;
            if (DateTime.TryParse(date, out temp))
            {
                return true;
            }
            Console.WriteLine("Try inputting date in mm/dd/yyyy format.");
            return false;
        }
        private void findEvent()
        {
            int id=50;
            Console.WriteLine("Enter id you want details of:");
            if(!int.TryParse(Console.ReadLine(),out id)){
                Console.WriteLine("Error in input. Please try again.");
                findEvent();
            }
            if (id < numOfEvent)
            {
                Console.WriteLine(events[id].ToString());
            }
            else
            {
                Console.WriteLine("No event found");
            }
        }
    }
}
