using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class CustomerEventHandler
    {
        private List<Event> events;
        private List<Customer> cust;
        public CustomerEventHandler()
        {
            events = new List<Event>();
            cust = new List<Customer>();
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
                        foreach (Event e in events)
                        {
                            Console.WriteLine(e.getEventInfo());
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
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
        public void CustomerOptions()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Andrew's Event Managment Limited.");
                Console.WriteLine("Customer Menu.");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1: Add Customer");
                Console.WriteLine("2: View Customers");
                Console.WriteLine("3: View Customer Details");
                Console.WriteLine("4: Delete Customer");
                Console.WriteLine("5: Return to the main menu.\n");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        AddCustomer();
                        break;
                    case '2':
                        foreach (Customer c in cust)
                        {
                            Console.WriteLine(c.ToString() + "\n");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case '3':
                        FindCustomer();
                        break;
                    case '4':
                        DeleteCustomer();
                        break;
                    case '5':
                        return;
                    default:
                        break;
                }
            }
        }
        private void AddCustomer()
        {
            string fName, lName;
            Console.Clear();
            Console.WriteLine("Enter first name: ");
            fName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lName = Console.ReadLine();
            cust.Add(new Customer(cust.Count, fName, lName));
        }
        private void FindCustomer()
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
        private void DeleteCustomer()
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

        private void findEvent()
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
