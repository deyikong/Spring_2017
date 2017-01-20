using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Student
    {
        private string email;
        private string firstName;
        private string lastName;
        private string cell;
        private string address;


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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string CellPhone
        {
            get
            {
                return cell;
            }

            set
            {
                cell = value;
            }
        }

        public Student(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public List<double> GetGrades()
        {
            return new List<double>();
        }

        public double GetGradeForHomework(int homeworkNumber)
        {
            return 10.1;
        }
    }
}
