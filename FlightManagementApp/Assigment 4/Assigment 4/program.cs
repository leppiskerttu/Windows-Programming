using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        AirlineCompany airlineCompany = new AirlineCompany("Niko Air");

        Console.WriteLine(airlineCompany.AirlineName);


        airlineCompany[1] = new Flight(1, "Vaasa", "Tukholma", DateTime.Parse("2023-10-20"), 500.0);
        airlineCompany[2] = new Flight(2, "Helsinki", "Berliini", DateTime.Parse("2023-10-22"), 400.0);
        airlineCompany[3] = new Flight(3, "Lontoo", "Dubai", DateTime.Parse("2023-10-25"), 300.0);
        airlineCompany[4] = new Flight(4, "Tukholma", "Helsinki", DateTime.Parse("2023-10-27"), 200.0);
        airlineCompany[5] = new Flight(5, "Dubai", "Lontoo", DateTime.Parse("2023-10-30"), 100.0);
        Console.WriteLine(airlineCompany[5]);

        // Print flights
        Console.WriteLine(airlineCompany.DisplayFlights());

        //Find flight with ID 4
        int flightIdToFind = 4;
        Flight foundFlight = airlineCompany.FindFlight(flightIdToFind);
        if (foundFlight != null)
                {
                    Console.WriteLine($"Flight with ID {flightIdToFind} found:\n{foundFlight}");
                }
                else
                {
                    Console.WriteLine($"Flight with ID {flightIdToFind} not found.");
                }

        Flight cheapestFlight = airlineCompany.GetCheapestFlight();
        Flight mostExpensiveFlight = airlineCompany.GetMostExpensiveFlight();

        // Print the cheapest flight details
        Console.WriteLine("Cheapest Flight:\n" + (cheapestFlight?.ToString()));

        // Print the most expensive flight details
        Console.WriteLine("\nMost Expensive Flight:\n" + (mostExpensiveFlight?.ToString()));

    }
}