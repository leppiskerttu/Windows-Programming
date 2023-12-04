using System;

namespace AssignmentVII
{
    public interface IHotel
    {
        string Name { get; set; }
        string ConstructionDate { get; set; }
        string Address { get; set; }
        int Stars { get; set; }

        List<Room> Rooms { get; set; }
        List<Customer> Customers { get; set; }


        void SaveBinaryData(string fileName);

        void SearchAndLoadBinaryData(string searchHotelName, int searchRoomNumber, string searchCustomer, string fileName);

        void WriteToTextFile(string fileName);

        string SearchFromText(string searchTerm, string fileName);

        void DisplaySavedText(string fileName);

        void SerializeXML(string fileName);

        void SerializeToJson(string fileName);

        string ToString();
    }
}