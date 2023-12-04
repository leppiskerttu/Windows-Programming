using AssignmentVII;
using System;
using System.Collections.Generic;
using System.IO;

[Serializable]
public class Customer: ICustomer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int RoomNumber { get; set; }
    public string ArrivalDate { get; set; }
    public int LengthOfStay { get; set; }


    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Room Number: {RoomNumber}, Arrival Date: {ArrivalDate}, Length of Stay: {LengthOfStay} days";
    }
}

