using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace AssignmentVII

{
    [Serializable]

    public class Hotel : IHotel
    {


        public string Name { get; set; }
        public String ConstructionDate { get; set; }
        public string Address { get; set; }
        public int Stars { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Customer> Customers { get; set; } = new List<Customer>();



        public void DisplayHotelInformation(Hotel hotel)
        {
            Console.WriteLine("Hotel Data:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Construction Date: {ConstructionDate}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Stars: {Stars}");

            Console.WriteLine("\nRooms:");
            foreach (var room in Rooms)
            {
                Console.WriteLine($"Room Number: {room.RoomNumber}, Type: {room.Type}, Price: {room.PricePerNight}, Description : {room.Description}");
            }

            Console.WriteLine("\nCustomers:");
            foreach (var customer in Customers)
            {
                Console.WriteLine($"Name: {customer.FirstName} {customer.LastName}, Room Number: {customer.RoomNumber}, Arrival Date: {customer.ArrivalDate}, Length of Stay: {customer.LengthOfStay} nights");
            }
        }


        public void SaveBinaryData(string fileName)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(Name);
                writer.Write(ConstructionDate);
                writer.Write(Address);
                writer.Write(Stars);

                writer.Write(Rooms.Count);
                foreach (var room in Rooms)
                {
                    writer.Write(room.RoomNumber);
                    writer.Write(room.Area);
                    writer.Write(room.Type);
                    writer.Write(room.PricePerNight);
                    writer.Write(room.Description);
                }

                writer.Write(Customers.Count);
                foreach (var customer in Customers)
                {
                    writer.Write(customer.FirstName);
                    writer.Write(customer.LastName);
                    writer.Write(customer.RoomNumber);
                    writer.Write(customer.ArrivalDate);
                    writer.Write(customer.LengthOfStay);
                }
            }
        }

        public void SearchAndLoadBinaryData(string searchHotelName, int searchRoomNumber, string searchCustomer, string fileName)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Name = reader.ReadString();
                ConstructionDate = reader.ReadString();
                Address = reader.ReadString();
                Stars = reader.ReadInt32();

                if (Name == searchHotelName)
                {
                    Console.WriteLine($"\nFound hotel {searchHotelName}:");
                    Console.WriteLine($"Construction Date: {ConstructionDate}");
                    Console.WriteLine($"Address: {Address}");
                    Console.WriteLine($"Stars: {Stars}");
                }
                int roomCount = reader.ReadInt32();
                Rooms.Clear();
                for (int i = 0; i < roomCount; i++)
                {
                    Room room = new Room
                    {
                        RoomNumber = reader.ReadInt32(),
                        Area = reader.ReadDouble(),
                        Type = reader.ReadString(),
                        PricePerNight = reader.ReadDouble(),
                        Description = reader.ReadString()
                    };
                    Rooms.Add(room);

                    if (room.RoomNumber == searchRoomNumber)
                    {
                        Console.WriteLine($"\nFound room with RoomNumber {searchRoomNumber} in {Name}:");
                        Console.WriteLine($"Area: {room.Area}");
                        Console.WriteLine($"Type: {room.Type}");
                        Console.WriteLine($"Price Per Night: {room.PricePerNight}");
                        Console.WriteLine($"Description: {room.Description}");
                    }
                }

                int customerCount = reader.ReadInt32();
                Customers.Clear();
                for (int i = 0; i < customerCount; i++)
                {
                    Customer customer = new Customer
                    {
                        FirstName = reader.ReadString(),
                        LastName = reader.ReadString(),
                        RoomNumber = reader.ReadInt32(),
                        ArrivalDate = reader.ReadString(),
                        LengthOfStay = reader.ReadInt32()
                    };
                    Customers.Add(customer);

                    if (customer.FirstName + " " + customer.LastName == searchCustomer)
                    {
                        Console.WriteLine($"\nFound customer {searchCustomer} in {Name}:");
                        Console.WriteLine($"RoomNumber: {customer.RoomNumber}");
                        Console.WriteLine($"Arrival Date: {customer.ArrivalDate}");
                        Console.WriteLine($"Length of Stay: {customer.LengthOfStay} nights");
                    }
                }
            }
        }


        public void WriteToTextFile(string fileName)
        {
            using (TextWriter Textwriter = new StreamWriter(fileName))
            {
                Textwriter.WriteLine($"Hotel name: {Name}");
                Textwriter.WriteLine($"Construction date: {ConstructionDate}");
                Textwriter.WriteLine($"Address: {Address}");
                Textwriter.WriteLine($"Stars: {Stars}");

                Textwriter.WriteLine("\nRooms:");
                foreach (var room in Rooms)
                {
                    Textwriter.WriteLine($"Room number: {room.RoomNumber}");
                    Textwriter.WriteLine($"Area: {room.Area}");
                    Textwriter.WriteLine($"Type: {room.Type}");
                    Textwriter.WriteLine($"Price per night: {room.PricePerNight}");
                    Textwriter.WriteLine($"Description: {room.Description}");
                    Textwriter.WriteLine();
                }

                Textwriter.WriteLine("\nCustomers:");
                foreach (var customer in Customers)
                {
                    Textwriter.WriteLine($"First name: {customer.FirstName}");
                    Textwriter.WriteLine($"Last name: {customer.LastName}");
                    Textwriter.WriteLine($"Room number: {customer.RoomNumber}");
                    Textwriter.WriteLine($"Arrival date: {customer.ArrivalDate}");
                    Textwriter.WriteLine($"Length of stay: {customer.LengthOfStay}");
                    Textwriter.WriteLine();
                }
            }
        }

        public string SearchFromText(string searchTerm, string fileName)
        {
            try
            {
                using (TextReader textreader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = textreader.ReadLine()) != null)
                    {
                        if (line.Contains(searchTerm))
                        {

                            StringBuilder SearchDetails = new StringBuilder();
                            SearchDetails.AppendLine(line);
                            SearchDetails.AppendLine(textreader.ReadLine());
                            SearchDetails.AppendLine(textreader.ReadLine());
                            SearchDetails.AppendLine(textreader.ReadLine());
                            SearchDetails.AppendLine(textreader.ReadLine());

                            return $"\nFound:\n{SearchDetails}";
                        }
                    }
                }
                return $"Search term '{searchTerm}' not found in the file.";
            }
            catch (FileNotFoundException)
            {
                return $"File not found";
            }
        }

        public void DisplaySavedText(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }





        public void SerializeXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Hotel));

            using (TextWriter textWriter = new StreamWriter(fileName))
            {
                serializer.Serialize(textWriter, this);
            }
        }

        public static Hotel DeserializeXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Hotel));

            using (TextReader textReader = new StreamReader(fileName))
            {
                return (Hotel)serializer.Deserialize(textReader);
            }
        }

        public void SerializeToJson(string fileName)
        {
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, jsonString);
        }

        public static Hotel DeserializeFromJson(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Hotel>(jsonString);
        }


        public override string ToString()
        {
            return $"Hotel: {Name}, Construction Date: {ConstructionDate}, Address: {Address}, Stars: {Stars}, Rooms: {Rooms.Count}";
        }
    }
}