using System;
using System.Diagnostics;
using AssigmentVfunc;

namespace AssigmentVfunc
{
    class Program
    {
        static void Main()
        {
            // Luo CustomEventHandlerin instanssi
            CustomEventHandler eventHandler = new CustomEventHandler();

            Console.WriteLine("1. Add Events\n");

            
            Console.WriteLine(eventHandler.AddEvent("Event1", "Type1", "Location1", DateTime.Parse("2023-11-09"), 30.0));
            Console.WriteLine(eventHandler.AddEvent("Event2", "Type2", "Location2", DateTime.Parse("2023-11-10"), 40.0));
            Console.WriteLine(eventHandler.AddEvent("Event3", "Type3", "Location3", DateTime.Parse("2024-02-15"), 25.0));

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("2. Event date matches the given date:\n");
            DateTime specificDate = DateTime.Parse("2023-11-09");
            eventHandler.HandleEvent((date, customEvent) => customEvent.Date == date ? customEvent.ToString() : "No event found",specificDate);

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("3. Print events with a price less than 40:\n");
            // Käsittele tapahtumia antamalla toiminnon(Action) kaksi parametria: price ja customEvent
            double maxPrice = 40;
            Action<double, CustomEvent> printAction=(price,customEvent) => Console.WriteLine(customEvent.Price < price ?customEvent :"");
            eventHandler.HandleEvent(printAction, maxPrice);
   
            

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("4. Comparing locations with Location2:\n");
            eventHandler.HandleEvent(customEvent =>
            {
                // Tarkista, onko tapahtuman sijainti sama kuin annettu sijainti (Location2)
                bool locationMatch = customEvent.Location == "Location2";
                Console.WriteLine($"{customEvent.Name} - Location Match: {locationMatch}");
                return locationMatch;
            });

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("5. Searching events with Event2:\n");

            string result = eventHandler.SearchEvent(name: "Event2", type: "Type2", location: "Location2", date: DateTime.Parse("2023-11-10"), price: 40.0);


            // Print the result
            Console.WriteLine(result);

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("Log:\n");
            Console.WriteLine(CustomEventHandler.Log);
        }
    }
}