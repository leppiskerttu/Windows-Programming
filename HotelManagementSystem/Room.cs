using AssignmentVII;
using System;
using System.Collections.Generic;
using System.IO;


[Serializable]
public class Room: IRoom
{
    public int RoomNumber { get; set; }
    public double Area { get; set; }
    public string Type { get; set; }
    public double PricePerNight { get; set; }
    public string Description { get; set; }


    public override string ToString()
    {
        return $"Room Number: {RoomNumber}, Type: {Type}, Area: {Area} sq. ft, Price per Night: {PricePerNight:C}, Description: {Description}";
    }
}
