using System;

namespace AssignmentVII
{
    class Program
    {
        static void Main()
        {
            Hotel myHotel = new Hotel { Name = "Niko hotel", ConstructionDate = "22-10-1984", Address = "Ahventie 22-24", Stars = 5 };

            myHotel.Rooms.Add(new Room { RoomNumber = 101, Area = 300, Type = "Huone", PricePerNight = 350, Description = "NormiHuone", });
            myHotel.Rooms.Add(new Room { RoomNumber = 201, Area = 400, Type = "Sviitti", PricePerNight = 600, Description = "HääSviitti", });

            myHotel.Customers.Add(new Customer { FirstName = "Matti", LastName = "Mies", RoomNumber = 101, ArrivalDate = "2023-11-20", LengthOfStay = 3 });
            myHotel.Customers.Add(new Customer { FirstName = "Pekka", LastName = "Poika", RoomNumber = 201, ArrivalDate = "2023-13-21", LengthOfStay = 5 });


            Console.WriteLine("Binary data saved successfully.");
            myHotel.SaveBinaryData(@"C:\Users\e2102947\hotellit.dat");

            string searchHotelName = "Niko hotel";
            int searchRoomNumber = 101;
            string searchCustomer = "Matti Mies";

            Hotel HotelBinary = new Hotel();
            HotelBinary.SearchAndLoadBinaryData(searchHotelName, searchRoomNumber, searchCustomer, @"C:\Users\e2102947\hotellit.dat");

            Console.WriteLine("Hotellit.txt data saved successfully.");
            myHotel.WriteToTextFile(@"C:\Users\e2102947\hotellit.txt");


            Hotel HotelText = new Hotel();
            Console.WriteLine("Search from text file:");
            string searchTerm = "Matti";
            string result = HotelText.SearchFromText(searchTerm, @"C:\Users\e2102947\hotellit.txt");
            Console.WriteLine(result);


            myHotel.DisplaySavedText(@"C:\Users\e2102947\hotellit.txt");

            myHotel.SerializeXML(@"C:\Users\e2102947\hotellit.xml");

            Hotel deserializedHotel = Hotel.DeserializeXML(@"C:\Users\e2102947\hotellit.xml");


            myHotel.SerializeToJson(@"C:\Users\e2102947\hotellit.json");


            Hotel deserializedHotelJSON = Hotel.DeserializeFromJson(@"C:\Users\e2102947\hotellit.json");

            Console.WriteLine("\nData loaded from XML file:");
            deserializedHotel.DisplayHotelInformation(deserializedHotel);

            Console.WriteLine("\nData loaded from JSON file:");
            deserializedHotelJSON.DisplayHotelInformation(deserializedHotelJSON);
        }
    }
}

