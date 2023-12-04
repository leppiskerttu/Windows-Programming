using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentVII
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int RoomNumber { get; set; }
        string ArrivalDate { get; set; }
        int LengthOfStay { get; set; }

        string ToString();
    }
}
