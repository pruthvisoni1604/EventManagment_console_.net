using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class Program
    {
        private static Handler eh;
        static void Main(string[] args)
        {
            eh = new Handler();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Andrew's Event Managment Limited.");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. Customer Options");
                Console.WriteLine("2. Event Options");
                Console.WriteLine("3. RSVP for Event");
                Console.WriteLine("4. Exit\n");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        CustomerOptions();
                        break;
                    case '2':
                        EventOptions();
                        break;
                    case '3':
                        RSVPOptions();
                        break;
                    case '4':
                        Console.WriteLine("Thank you for using Andrew's Event Managment System.");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Entered value does not match with choices given.");
                        Console.WriteLine("Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void RSVPOptions()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Andrew's Event Managment Limited.");
                Console.WriteLine("Event Registration Menu.");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1: RSVP for event");
                Console.WriteLine("2: View RSVPs");
                Console.WriteLine("3: Return to the main menu.");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        eh.RSVPForEvent();
                        break;
                    case '2':
                        break;
                    case '3':
                        return;
                    default:
                        break;
                }
            }
        }
        private static void EventOptions()
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
                        eh.AddEvent();
                        break;
                    case '2':
                        foreach (Event e in eh.events)
                        {
                            Console.WriteLine(e.getEventInfo());
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case '3':
                        eh.findEvent();
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
        private static void CustomerOptions()
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
                        eh.AddCustomer();
                        break;
                    case '2':
                        foreach (Customer c in eh.cust)
                        {
                            Console.WriteLine(c.ToString() + "\n");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case '3':
                        eh.FindCustomer();
                        break;
                    case '4':
                        eh.DeleteCustomer();
                        break;
                    case '5':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
