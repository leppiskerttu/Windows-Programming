using System;
using System.Collections.Generic;
using System.Text;

public class AirlineCompany
{
    SortedList<Flight, double> flights = new SortedList<Flight, double>();
    //sortedlistin key value on flight objecti ja double hinta

    readonly string airlineName;


    public AirlineCompany(string AirlineName)
    {
        this.airlineName = AirlineName;
    }
    public string AirlineName { get { return airlineName; } }
   
    //indexer mahdollistaa lentojen hakemisen indeksin kautta
    public Flight this[int index]
    {
        get
        {
            

            foreach (Flight flight in flights.Keys)
            {
                

                if (flight.Id == index)
                {
                   

                    return flight;
                    
                }
            }

          
            return null;
        }
        set
        {
            
            flights.Add(value, value.Price);
        }
    }



    public Flight FindFlight(int flightId)
    {
        foreach (var flight in flights)
            //käydään läpi jokainen variable flight joka on flights sortedlistissa
        {
            if (flight.Key.Id == flightId)
                //jos flightin id on sama kuin etsittävä id
            {
                return flight.Key;
               
            }
        }
        return null;
        
    }

    public Flight GetCheapestFlight()
    {
        return flights.Keys[0];
        //palautetaan halvin lento
    }

    public Flight GetMostExpensiveFlight()
    {
        return flights.Keys[flights.Count - 1];
        //palautetaan kallein lento
    }

    public string DisplayFlights()
    {
        StringBuilder allFlightsInfo = new StringBuilder();

        foreach (var flight in flights.Keys)
        {
        allFlightsInfo.Append(flight.ToString()+Environment.NewLine);
        }
        return allFlightsInfo.ToString();
    }

}