using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializers
{
    class Customer
    {
        private int _id;
        private string _email;
        public Customer(int id)
        {
            _id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthday.Year;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

    }
}
