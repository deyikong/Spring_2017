using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{

    enum UserStatus:byte
    {
        Active,
        Disable,
        Suspended
    }
    enum Gender
    {
        Male,
        Female
    }

    class Program
    {
        static UserStatus GetStatus()
        {
            return UserStatus.Active;
        }

        static Gender GetGender()
        {
            return Gender.Male;
        }

        static void Main(string[] args)
        {
            Gender gender = Gender.Male;
            string x = "male";
            if (x == "male")
            {
                gender = Gender.Male;
            }
            if (gender == Gender.Male)
            {
                
            }
            //Active
            if(GetStatus()==UserStatus.Active)
            {
                Console.WriteLine("Succeeded");
            }
            Console.WriteLine(GetStatus());
        }
    }
}
