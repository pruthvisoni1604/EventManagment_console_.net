using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class Handler
    {
        public List<Event> events;
        public List<Customer> cust;
        public Handler()
        {
            events = new List<Event>();
            cust = new List<Customer>();
        }
        public void AddCustomer()
        {
            string fName, lName;
            Console.Clear();
            Console.WriteLine("Enter first name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lName = Console.ReadLine();
            cust.Add(new Customer(cust.Count, fName, lName));
        }
        public void FindCustomer()
        {
            int id = readId();

            if (id < cust.Count)
            {
                Console.WriteLine(cust[id].ToString());
            }
            else
            {
                Console.WriteLine("No customer found");
            }
            Console.ReadKey();
        }
        public void DeleteCustomer()
        {
            int id = readId();
            if (id < cust.Count)
            {
                cust.RemoveAt(id);
                for (int i = id; i < cust.Count; i++)
                {
                    cust[i].decrementId();
                }
            }
            else
            {
                Console.WriteLine("No customer found");
            }
            Console.ReadKey();
        }
        public void AddEvent()
        {
            string name, venue, date = "";
            DateTime eventDate;
            int numOfAttendee = 10;
            Console.Clear();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter venue");
            venue = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter date");
                date = Console.ReadLine();
            } while (!checkDate(date));
            eventDate = DateTime.Parse(date);
            Console.WriteLine("Enter number of attendees");
            if (!int.TryParse(Console.ReadLine(), out numOfAttendee))
            {
                Console.WriteLine("Error in input.\nDefault value added.");
            };
            events.Add(new Event(events.Count, name, venue, eventDate, numOfAttendee));
        }
        public void findEvent()
        {
            int id = readId();

            if (id < events.Count)
            {
                Console.WriteLine(events[id].ToString());
            }
            else
            {
                Console.WriteLine("No event found");
            }
            Console.ReadKey();
        }
        public void RSVPForEvent()
        {
            int custId, eventId;
            Console.WriteLine("Enter Event ID");
            eventId = readId();

            Console.WriteLine("Enter Customer ID");
            custId = readId();

            if (eventId < events.Count)
            {
                if (custId < cust.Count)
                {
                    events[eventId].addAttendee(cust[custId]);
                }
                else
                {
                    Console.WriteLine("No customer found");
                }
            }
            else
            {
                Console.WriteLine("No event found");
            }
            Console.ReadKey();
        }
        public void viewRSVP()
        {

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
        private int readId()
        {
            do
            {
                Console.WriteLine("Enter id :");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.Clear();
                    Console.WriteLine("Error in input. Please try again.");
                }
                else
                {
                    return id;
                }
            } while (true);
        }
    }
}
