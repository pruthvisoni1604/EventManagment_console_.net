using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Andrew's Event Managment Limited.");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1: Customer Options");
                Console.WriteLine("2: Event Options");
                Console.WriteLine("3: RSVP for Event");
                Console.WriteLine("4: Exit\n");

                switch (Console.ReadKey().ToString())
                {
                    case "1":
                        CustomerOptions();
                        break;
                    case "2":
                        EventOptions();
                        break;
                    case "3":
                        RSVPForEvent();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Andrew's Event Managment System.");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                        return;
                    default:

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
                Console.WriteLine("2: View customers");
                Console.WriteLine("3: View customer Details");
                Console.WriteLine("4: Delete Customer");
                Console.WriteLine("5: Return to the main menu.\n");

                switch (Console.ReadKey().ToString())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        return;
                    default:
                        break;
                }
            }
        }
        private static void EventOptions()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Andrew's Event Managment Limited.");
                Console.WriteLine("Event Menu.");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1: Add Event");
                Console.WriteLine("2: View all Events");
                Console.WriteLine("3: View Event Details");
                Console.WriteLine("4: Return to the main menu.\n");

                switch (Console.ReadKey().ToString())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        return;
                    default:
                        break;
                }
            }
        }
        private static void RSVPForEvent()
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

                switch (Console.ReadKey().ToString())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
