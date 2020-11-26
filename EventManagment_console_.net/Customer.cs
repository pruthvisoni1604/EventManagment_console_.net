using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagment_console_.net
{
    class Customer
    {
        private int custId;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string dateCreated;

        public Customer(int custId, string fName, string lName, DateTime birthDate)
        {
            this.custId = custId;
            this.firstName = fName;
            this.lastName = lName;
            this.birthDate = birthDate;
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getId() { return custId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public override string ToString()
        {
            string s = "";
            return s;
        }
    }
}
