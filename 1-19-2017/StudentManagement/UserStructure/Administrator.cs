using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStructure
{
    class Administrator:IUser
    {
        private string adminName;
        private string address;
        private string cellPhone;
        private string email;
        private string firstName;
        private string homePhone;
        private string lastName;
        private string loginStatus;
        private string password;
        private string userId;

        public string AdminName
        {
            get
            {
                return adminName;
            }

            set
            {
                adminName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                cellPhone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                cellPhone = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string HomePhone
        {
            get
            {
                return homePhone; 
            }

            set
            {
                homePhone = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string LoginStatus
        {
            get
            {
                return loginStatus;
            }

            set
            {
                loginStatus = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string UserId
        {
            get
            {
                return userId;
            }

            set
            {
                this.userId = value;
            }
        }

        public bool UpdateCatalog()
        {
            return true;
        }

        public bool VerifyLogin()
        {
            throw new NotImplementedException();
        }
    }
}
