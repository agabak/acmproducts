using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public  string FullName
        {
            get {

                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    return fullName += FirstName;
                } 

                return fullName;
             }
        }

        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValide = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValide = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValide = false;
            return isValide;
        }

        public bool Save()
        {
            return true;
        }

        public Customer Retrive(int customerId)
        {
            return new Customer();
        }

        public List<Customer>  Retrive()
        {
            return new List<Customer>();
        }

    }

}
