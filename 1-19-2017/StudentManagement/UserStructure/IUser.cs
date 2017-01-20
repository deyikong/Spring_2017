using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStructure
{
    interface IUser
    {
        string FirstName
        { get; set; }

        string LastName
        { get; set; }

        string CellPhone
        { get; set; }

        string HomePhone
        { get; set; }

        string Address
        { get; set; }

        string Email
        { get; set; }

        string UserId
        { get; set; }

        string Password
        { get; set; }

        string LoginStatus
        { get; set; }

        bool VerifyLogin();
    }
}
