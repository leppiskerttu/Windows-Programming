using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentVII
{
    public interface IRoom
    {
        int RoomNumber { get; set; }
        double Area { get; set; }
        string Type { get; set; }
        double PricePerNight { get; set; }
        string Description { get; set; }

        string ToString();
    }
}