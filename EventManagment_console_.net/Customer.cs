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

        public Customer(int custId, string fName, string lName)
        {
            this.custId = custId;
            firstName = fName;
            lastName = lName;
        }

        public int getId() { return custId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public override string ToString()
        {
            string s = "Customer Id: " + custId + "\nCustomer first name: " + firstName + "\nCustomer last name: " + lastName;
            return s;
        }
        public void decrementId()
        {
            custId--;
        }
    }
}
